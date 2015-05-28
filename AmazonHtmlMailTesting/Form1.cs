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
using Amazon.Runtime;
using Amazon.SimpleEmail;
using Amazon.SimpleEmail.Model;
using Message = System.Windows.Forms.Message;

namespace AmazonHtmlMailTesting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonSend_Click(object sender, EventArgs e)
        {
            var FromSender = ConfigurationSettings.AppSettings["FromSender"];
            var To = TextBoxEmailAddresses.Text;

             var Subject = TextBoxSubject.Text;
            var Body =  PreMailer.Net.PreMailer.MoveCssInline(TextBoxHtml.Text).Html;
            // Construct an object to contain the recipient address.
            Destination destination = new Destination();
            destination.ToAddresses = (new List<string>() { To });

            // Create the subject and body of the message.
            Content subject = new Content(Subject);
            Content textBody = new Content(Body);
            Body body = new Body();
            body.Html = textBody;

            // Create a message with the specified subject and body.
            Amazon.SimpleEmail.Model.Message message = new Amazon.SimpleEmail.Model.Message(subject, body);
            
            // Assemble the email.
            SendEmailRequest request = new SendEmailRequest(FromSender, destination, message);
            
            // Choose the AWS region of the Amazon SES endpoint you want to connect to. Note that your sandbox 
            // status, sending limits, and Amazon SES identity-related settings are specific to a given 
            // AWS region, so be sure to select an AWS region in which you set up Amazon SES. Here, we are using 
            // the US West (Oregon) region. Examples of other regions that Amazon SES supports are USEast1 
            // and EUWest1. For a complete list, see http://docs.aws.amazon.com/ses/latest/DeveloperGuide/regions.html 
            Amazon.RegionEndpoint REGION = Amazon.RegionEndpoint.USEast1;
 
           
           
            // Instantiate an Amazon SES client, which will make the service call.
            AWSCredentials credentials = new BasicAWSCredentials(ConfigurationSettings.AppSettings["awsAccessKeyId"], ConfigurationSettings.AppSettings["awsSecretAccessKey"]);
            AmazonSimpleEmailServiceClient client = new AmazonSimpleEmailServiceClient(credentials,REGION);
           
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

      
    }
}
