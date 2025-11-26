namespace Bai_2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtURL = new TextBox();
            btnDownload = new Button();
            rtbContent = new RichTextBox();
            txtFile = new TextBox();
            SuspendLayout();
            // 
            // txtURL
            // 
            txtURL.Location = new Point(12, 12);
            txtURL.Name = "txtURL";
            txtURL.Size = new Size(723, 27);
            txtURL.TabIndex = 0;
            // 
            // btnDownload
            // 
            btnDownload.Font = new Font("Segoe UI", 12F);
            btnDownload.Location = new Point(741, 12);
            btnDownload.Name = "btnDownload";
            btnDownload.Size = new Size(129, 64);
            btnDownload.TabIndex = 1;
            btnDownload.Text = "Download";
            btnDownload.UseVisualStyleBackColor = true;
            btnDownload.Click += btnDownload_Click;
            // 
            // rtbContent
            // 
            rtbContent.Location = new Point(12, 82);
            rtbContent.Name = "rtbContent";
            rtbContent.Size = new Size(858, 413);
            rtbContent.TabIndex = 2;
            rtbContent.Text = "";
            // 
            // txtFile
            // 
            txtFile.Location = new Point(12, 49);
            txtFile.Name = "txtFile";
            txtFile.Size = new Size(723, 27);
            txtFile.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(883, 507);
            Controls.Add(txtFile);
            Controls.Add(rtbContent);
            Controls.Add(btnDownload);
            Controls.Add(txtURL);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtURL;
        private Button btnDownload;
        private RichTextBox rtbContent;
        private TextBox txtFile;
    }
}
