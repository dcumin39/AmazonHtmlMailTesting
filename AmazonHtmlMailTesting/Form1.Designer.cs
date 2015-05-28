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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBoxSubject = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxEmailAddresses = new System.Windows.Forms.TextBox();
            this.ButtonSend = new System.Windows.Forms.Button();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.checkBoxValidateOutlook2007 = new System.Windows.Forms.CheckBox();
            this.TextBoxHtml = new System.Windows.Forms.RichTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.TextBoxPreview = new System.Windows.Forms.RichTextBox();
            this.previewButton = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-4, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1010, 431);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.previewButton);
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
            this.tabPage1.Size = new System.Drawing.Size(1002, 405);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.TextBoxPreview);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1002, 405);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            this.TextBoxSubject.TabIndex = 14;
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
            this.TextBoxEmailAddresses.TabIndex = 11;
            // 
            // ButtonSend
            // 
            this.ButtonSend.Location = new System.Drawing.Point(914, 353);
            this.ButtonSend.Name = "ButtonSend";
            this.ButtonSend.Size = new System.Drawing.Size(75, 23);
            this.ButtonSend.TabIndex = 10;
            this.ButtonSend.Text = "Send";
            this.ButtonSend.UseVisualStyleBackColor = true;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // checkBoxValidateOutlook2007
            // 
            this.checkBoxValidateOutlook2007.AutoSize = true;
            this.checkBoxValidateOutlook2007.Checked = true;
            this.checkBoxValidateOutlook2007.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxValidateOutlook2007.Location = new System.Drawing.Point(678, 357);
            this.checkBoxValidateOutlook2007.Name = "checkBoxValidateOutlook2007";
            this.checkBoxValidateOutlook2007.Size = new System.Drawing.Size(149, 17);
            this.checkBoxValidateOutlook2007.TabIndex = 18;
            this.checkBoxValidateOutlook2007.Text = "Validate For Outlook 2007";
            this.checkBoxValidateOutlook2007.UseVisualStyleBackColor = true;
            // 
            // TextBoxHtml
            // 
            this.TextBoxHtml.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.TextBoxHtml.Location = new System.Drawing.Point(15, 51);
            this.TextBoxHtml.Name = "TextBoxHtml";
            this.TextBoxHtml.Size = new System.Drawing.Size(977, 296);
            this.TextBoxHtml.TabIndex = 17;
            this.TextBoxHtml.Text = "";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 383);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1002, 22);
            this.statusStrip1.TabIndex = 16;
            this.statusStrip1.Text = "StatusStrip";
            // 
            // TextBoxPreview
            // 
            this.TextBoxPreview.Location = new System.Drawing.Point(0, 3);
            this.TextBoxPreview.Name = "TextBoxPreview";
            this.TextBoxPreview.Size = new System.Drawing.Size(999, 399);
            this.TextBoxPreview.TabIndex = 0;
            this.TextBoxPreview.Text = "";
            // 
            // previewButton
            // 
            this.previewButton.Location = new System.Drawing.Point(833, 353);
            this.previewButton.Name = "previewButton";
            this.previewButton.Size = new System.Drawing.Size(75, 23);
            this.previewButton.TabIndex = 19;
            this.previewButton.Text = "Preview";
            this.previewButton.UseVisualStyleBackColor = true;
            this.previewButton.Click += new System.EventHandler(this.previewButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 456);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        public System.Windows.Forms.Button previewButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBoxSubject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxEmailAddresses;
        private System.Windows.Forms.Button ButtonSend;
        private System.Windows.Forms.CheckBox checkBoxValidateOutlook2007;
        private System.Windows.Forms.RichTextBox TextBoxHtml;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.RichTextBox TextBoxPreview;

    }
}

