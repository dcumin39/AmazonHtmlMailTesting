using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.IO;
using System.Net.Mail;
using Amazon.Runtime;
using Amazon.SimpleEmail;
using Amazon.SimpleEmail.Model;
using MailBee.Outlook;
using Message = System.Windows.Forms.Message;

namespace AmazonHtmlMailTesting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static readonly List<string> InvalidOutLookCss = new List<string> {
            "background-attachment:", 
            "background-image:",
            "background-position:",
        "background-repeat:",
        "clear:",
        "display:",
        "float:",
        "list-style-image:",
        "list-style-position:",
        "text-transform:",
        "word-spacing:",
        "azimuth:",
        "background-attachment:",
        "background-image:",
        "background-position:",
        "background-repeat:",
        "border-spacing:",
        "bottom:",
        "caption-side:",
        "clear^:",
        "clip:",
        "content:",
        "counter-increment:",
        "counter-reset:",
        "cue-before, cue-after, cue:",
        "cursor:",
        "display:",
        "elevation:",
        "empty-cells:",
        "float:",
        "font-size-adjust:",
        "font-stretch:",
        "left:",
        "line-break:",
        "list-style-image:",
        "list-style-position:",
        "marker-offset:",
        "max-height:",
        "max-width:",
        "min-height:",
        "min-width:",
        "orphans:",
        "outline:",
        "outline-color:",
        "outline-style:",
        "outline-width:",
        "overflow:",
        "overflow-x:",
        "overflow-y:",
        "pause-before, pause-after, pause:",
        "pitch:",
        "pitch-range:",
        "play-during:",
        "position:",
        "quotes:",
        "richness:",
        "right:",
        "speak:",
        "speak-header:",
        "speak-numeral:",
        "speak-punctuation:",
        "speech-rate:",
        "stress:",
        "table-layout:",
        "text-shadow:",
        "text-transform:",
        "top:",
        "unicode-bidi:",
        "visibility:",
        "voice-family:",
        "volume:",
        "widows:",
        "word-spacing:",
        "z-index:"
        };

        public class EmailParamsFromForm
        {
            public string FromSender { get; set; }

            public string To { get; set; }

            public string Subject { get; set; }

            public string Body { get; set; }

        }
        private void ButtonSend_Click(object sender, EventArgs e)
        {


          

            var emailParameters = GetEmailParamsFromForm();
            if (emailParameters == null)
            {
                return;
            }

            // Construct an object to contain the recipient address.
            Destination destination = new Destination();
            destination.ToAddresses = (new List<string>() { emailParameters.To });

            // Create the subject and body of the message.
            Content subject = new Content(emailParameters.Subject);
            Content textBody = new Content(emailParameters.Body);
            Body body = new Body();
            body.Html = textBody;

            // Create a message with the specified subject and body.
            Amazon.SimpleEmail.Model.Message message = new Amazon.SimpleEmail.Model.Message(subject, body);

            // Assemble the email.
            SendEmailRequest request = new SendEmailRequest(emailParameters.FromSender, destination, message);

            // Choose the AWS region of the Amazon SES endpoint you want to connect to. Note that your sandbox 
            // status, sending limits, and Amazon SES identity-related settings are specific to a given 
            // AWS region, so be sure to select an AWS region in which you set up Amazon SES. Here, we are using 
            // the US West (Oregon) region. Examples of other regions that Amazon SES supports are USEast1 
            // and EUWest1. For a complete list, see http://docs.aws.amazon.com/ses/latest/DeveloperGuide/regions.html 
            Amazon.RegionEndpoint REGION = Amazon.RegionEndpoint.USEast1;



            // Instantiate an Amazon SES client, which will make the service call.
            AWSCredentials credentials = new BasicAWSCredentials(ConfigurationSettings.AppSettings["awsAccessKeyId"], ConfigurationSettings.AppSettings["awsSecretAccessKey"]);
            AmazonSimpleEmailServiceClient client = new AmazonSimpleEmailServiceClient(credentials, REGION);

            // Send the email.
            try
            {
                toolStripStatusLabel1.Text = "Attempting to send an email through Amazon SES by using the AWS SDK for .NET...";
                statusStrip1.Refresh();
                client.SendEmail(request);
                toolStripStatusLabel1.Text = "Email sent!";
            }
            catch (Exception ex)
            {

                toolStripStatusLabel1.Text = "Not Sent.  Error message: " + ex.Message;
                statusStrip1.Refresh();
            }


            toolStripStatusLabel1.Text = "Email sent succesfully!";
            statusStrip1.Refresh();


        }

        private EmailParamsFromForm GetEmailParamsFromForm( )
        {
            var text = TextBoxHtml.Text;
            if (checkBoxValidateOutlook2007.Checked)
            {
                if (TestForValidOutLook2007(text)) return null;
            }

            return new EmailParamsFromForm()
            {
                Body = PreMailer.Net.PreMailer.MoveCssInline(text).Html,
                Subject = TextBoxSubject.Text,
                To = TextBoxEmailAddresses.Text,
                FromSender = ConfigurationSettings.AppSettings["FromSender"]
            };
        }

        private bool TestForValidOutLook2007(string text)
        {
            var listofInvalidCSS = InvalidOutLookCss.Where(p => text.Contains(p));
            if (listofInvalidCSS.Any())
            {
                string alertMessage = "You have the following invalid css elements " +
                                      string.Join(",", listofInvalidCSS.ToArray());
                ;
                string caption = "Error Detected in Input";
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                DialogResult result;
                result = MessageBox.Show(alertMessage, caption, buttons);

                if (result == DialogResult.Cancel)
                {
                    toolStripStatusLabel1.Text = "Canceled sending Email";
                    return true;
                }
            }
            return false;
        }

        private void previewButton_Click(object sender, EventArgs e)
        {

            var emailParameters = GetEmailParamsFromForm();
            if (emailParameters == null)
            {
                return;
            }
            var outLookMessage = new MailBee.Mime.MailMessage();
            outLookMessage.BodyHtmlText = emailParameters.Body;
            outLookMessage.From.Email = emailParameters.FromSender;
            outLookMessage.From.DisplayName = emailParameters.FromSender;
            outLookMessage.To.Add("Test Email", emailParameters.To);
            outLookMessage.Subject = emailParameters.Subject;
            MsgConvert conv = new MsgConvert();
            conv.MsgAsUnicode = true;
            conv.HtmlToRtfMethod = HtmlToRtfConversionMethod.Internal;
            conv.MsgAsDraft = false;
            var cTempResultMsg = "C:\\Temp\\result.msg";
            conv.MailMessageToMsg(outLookMessage, cTempResultMsg);
            MsgConvert convertToBodyHtml = new MsgConvert();
            var BodyHtmlMessage = convertToBodyHtml.MsgToMailMessage(cTempResultMsg);
             OutlookStorage.Message outlookMsg = new OutlookStorage.Message(cTempResultMsg);
             TextBoxPreview.Rtf = outlookMsg.BodyRTF;

        }
    }
}
