namespace AmazonHtmlMailTesting
{
    partial class AmazonHtmlTestForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBoxSubject = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxEmailAddresses = new System.Windows.Forms.TextBox();
            this.ButtonSend = new System.Windows.Forms.Button();
            this.checkBoxValidateOutlook2007 = new System.Windows.Forms.CheckBox();
            this.TextBoxHtml = new System.Windows.Forms.RichTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            label2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(12, 35);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(28, 13);
            label2.TabIndex = 13;
            label2.Text = "Html";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1012, 456);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.TextBoxSubject);
            this.tabPage1.Controls.Add(label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.TextBoxEmailAddresses);
            this.tabPage1.Controls.Add(this.ButtonSend);
            this.tabPage1.Controls.Add(this.checkBoxValidateOutlook2007);
            this.tabPage1.Controls.Add(this.TextBoxHtml);
            this.tabPage1.Controls.Add(this.statusStrip1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1004, 430);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Edit";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(539, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Subject";
            // 
            // TextBoxSubject
            // 
            this.TextBoxSubject.Location = new System.Drawing.Point(588, 6);
            this.TextBoxSubject.Name = "TextBoxSubject";
            this.TextBoxSubject.Size = new System.Drawing.Size(404, 20);
            this.TextBoxSubject.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Email";
            // 
            // TextBoxEmailAddresses
            // 
            this.TextBoxEmailAddresses.Location = new System.Drawing.Point(53, 6);
            this.TextBoxEmailAddresses.Name = "TextBoxEmailAddresses";
            this.TextBoxEmailAddresses.Size = new System.Drawing.Size(476, 20);
            this.TextBoxEmailAddresses.TabIndex = 1;
            // 
            // ButtonSend
            // 
            this.ButtonSend.Location = new System.Drawing.Point(917, 30);
            this.ButtonSend.Name = "ButtonSend";
            this.ButtonSend.Size = new System.Drawing.Size(75, 23);
            this.ButtonSend.TabIndex = 5;
            this.ButtonSend.Text = "Send";
            this.ButtonSend.UseVisualStyleBackColor = true;
            this.ButtonSend.Click += new System.EventHandler(this.ButtonSend_Click);
            // 
            // checkBoxValidateOutlook2007
            // 
            this.checkBoxValidateOutlook2007.AutoSize = true;
            this.checkBoxValidateOutlook2007.Checked = true;
            this.checkBoxValidateOutlook2007.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxValidateOutlook2007.Location = new System.Drawing.Point(762, 34);
            this.checkBoxValidateOutlook2007.Name = "checkBoxValidateOutlook2007";
            this.checkBoxValidateOutlook2007.Size = new System.Drawing.Size(149, 17);
            this.checkBoxValidateOutlook2007.TabIndex = 4;
            this.checkBoxValidateOutlook2007.Text = "Validate For Outlook 2007";
            this.checkBoxValidateOutlook2007.UseVisualStyleBackColor = true;
            // 
            // TextBoxHtml
            // 
            this.TextBoxHtml.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TextBoxHtml.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.TextBoxHtml.Location = new System.Drawing.Point(0, 51);
            this.TextBoxHtml.Name = "TextBoxHtml";
            this.TextBoxHtml.Size = new System.Drawing.Size(1004, 357);
            this.TextBoxHtml.TabIndex = 3;
            this.TextBoxHtml.Text = "";
            this.TextBoxHtml.TextChanged += new System.EventHandler(this.OnHtmlSourceChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 408);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1004, 22);
            this.statusStrip1.TabIndex = 16;
            this.statusStrip1.Text = "StatusStrip";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.webBrowser);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1004, 430);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "Preview Email";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // webBrowser
            // 
            this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser.Location = new System.Drawing.Point(0, 0);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(1004, 430);
            this.webBrowser.TabIndex = 7;
            // 
            // AmazonHtmlTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 456);
            this.Controls.Add(this.tabControl1);
            this.Name = "AmazonHtmlTestForm";
            this.Text = "AmazonHtmlTestForm";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBoxSubject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxEmailAddresses;
        private System.Windows.Forms.Button ButtonSend;
        private System.Windows.Forms.CheckBox checkBoxValidateOutlook2007;
        private System.Windows.Forms.RichTextBox TextBoxHtml;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.WebBrowser webBrowser;

    }
}

