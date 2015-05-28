namespace AmazonHtmlMailTesting
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label label2;
            this.ButtonSend = new System.Windows.Forms.Button();
            this.TextBoxEmailAddresses = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBoxSubject = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.TextBoxHtml = new System.Windows.Forms.RichTextBox();
            this.checkBoxValidateOutlook2007 = new System.Windows.Forms.CheckBox();
            label2 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(12, 41);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(28, 13);
            label2.TabIndex = 4;
            label2.Text = "Html";
            // 
            // ButtonSend
            // 
            this.ButtonSend.Location = new System.Drawing.Point(917, 368);
            this.ButtonSend.Name = "ButtonSend";
            this.ButtonSend.Size = new System.Drawing.Size(75, 23);
            this.ButtonSend.TabIndex = 0;
            this.ButtonSend.Text = "Send";
            this.ButtonSend.UseVisualStyleBackColor = true;
            this.ButtonSend.Click += new System.EventHandler(this.ButtonSend_Click);
            // 
            // TextBoxEmailAddresses
            // 
            this.TextBoxEmailAddresses.Location = new System.Drawing.Point(53, 12);
            this.TextBoxEmailAddresses.Name = "TextBoxEmailAddresses";
            this.TextBoxEmailAddresses.Size = new System.Drawing.Size(476, 20);
            this.TextBoxEmailAddresses.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(539, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Subject";
            // 
            // TextBoxSubject
            // 
            this.TextBoxSubject.Location = new System.Drawing.Point(588, 12);
            this.TextBoxSubject.Name = "TextBoxSubject";
            this.TextBoxSubject.Size = new System.Drawing.Size(404, 20);
            this.TextBoxSubject.TabIndex = 5;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 417);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1004, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "StatusStrip";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // TextBoxHtml
            // 
            this.TextBoxHtml.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.TextBoxHtml.Location = new System.Drawing.Point(15, 57);
            this.TextBoxHtml.Name = "TextBoxHtml";
            this.TextBoxHtml.Size = new System.Drawing.Size(977, 296);
            this.TextBoxHtml.TabIndex = 8;
            this.TextBoxHtml.Text = "";
            // 
            // checkBoxValidateOutlook2007
            // 
            this.checkBoxValidateOutlook2007.AutoSize = true;
            this.checkBoxValidateOutlook2007.Checked = true;
            this.checkBoxValidateOutlook2007.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxValidateOutlook2007.Location = new System.Drawing.Point(734, 374);
            this.checkBoxValidateOutlook2007.Name = "checkBoxValidateOutlook2007";
            this.checkBoxValidateOutlook2007.Size = new System.Drawing.Size(149, 17);
            this.checkBoxValidateOutlook2007.TabIndex = 9;
            this.checkBoxValidateOutlook2007.Text = "Validate For Outlook 2007";
            this.checkBoxValidateOutlook2007.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 439);
            this.Controls.Add(this.checkBoxValidateOutlook2007);
            this.Controls.Add(this.TextBoxHtml);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextBoxSubject);
            this.Controls.Add(label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxEmailAddresses);
            this.Controls.Add(this.ButtonSend);
            this.Name = "Form1";
            this.Text = "Form1";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonSend;
        private System.Windows.Forms.TextBox TextBoxEmailAddresses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBoxSubject;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.RichTextBox TextBoxHtml;
        private System.Windows.Forms.CheckBox checkBoxValidateOutlook2007;
    }
}

