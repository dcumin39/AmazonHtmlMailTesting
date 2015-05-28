using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.IO;
using System.Net.Mail;
using Amazon.Runtime;
using Amazon.SimpleEmail;
using Amazon.SimpleEmail.Model;

using Message = System.Windows.Forms.Message;

namespace AmazonHtmlMailTesting
{
    public partial class AmazonHtmlTestForm : Form
    {
        public AmazonHtmlTestForm()
        {
            InitializeComponent();
            TabColors = new Dictionary<TabPage, Color>() { { tabPage1, DefaultBackColor }, { tabPage2, DefaultBackColor } };
            this.tabControl1.DrawMode = TabDrawMode.OwnerDrawFixed;
            this.tabControl1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControl1_DrawItem);
        }

        private Dictionary<TabPage, Color> TabColors = new Dictionary<TabPage, Color>();
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

        private EmailParamsFromForm GetEmailParamsFromForm()
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

        private void OnHtmlSourceChanged(object sender, EventArgs e)
        {

            var emailParameters = GetEmailParamsFromForm();
            if (emailParameters == null)
            {
                return;
            }
            webBrowser.DocumentText = emailParameters.Body;
            //usage
            flickerPreviewTab();
            Action toDo = flickerPreviewTab;
            toDo.DelayFor(TimeSpan.FromMilliseconds(500));

        }

        private bool isTabColored = false;

        private void flickerPreviewTab()
        {
            if (isTabColored)
            {
                SetTabHeader(tabPage2, DefaultBackColor);
                isTabColored = false;
            }
            else
            {
                SetTabHeader(tabPage2, Color.Gray);
                isTabColored = true;
            }
            tabPage2.Refresh();


        }



        private void SetTabHeader(TabPage page, Color color)
        {
            TabColors[page] = color;
            tabControl1.Invalidate();
        }
        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            //e.DrawBackground();
            using (Brush br = new SolidBrush(TabColors[tabControl1.TabPages[e.Index]]))
            {
                e.Graphics.FillRectangle(br, e.Bounds);
                SizeF sz = e.Graphics.MeasureString(tabControl1.TabPages[e.Index].Text, e.Font);
                e.Graphics.DrawString(tabControl1.TabPages[e.Index].Text, e.Font, Brushes.Black, e.Bounds.Left + (e.Bounds.Width - sz.Width) / 2, e.Bounds.Top + (e.Bounds.Height - sz.Height) / 2 + 1);

                Rectangle rect = e.Bounds;
                rect.Offset(0, 1);
                rect.Inflate(0, -1);
                e.Graphics.DrawRectangle(Pens.DarkGray, rect);
                e.DrawFocusRectangle();
            }
        }
    }
}
