namespace Bai_1
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
            rtb_url = new RichTextBox();
            rtb_detail = new RichTextBox();
            bttn_get = new Button();
            SuspendLayout();
            // 
            // rtb_url
            // 
            rtb_url.Font = new Font("Segoe UI", 10F);
            rtb_url.Location = new Point(82, 48);
            rtb_url.Name = "rtb_url";
            rtb_url.Size = new Size(626, 53);
            rtb_url.TabIndex = 12;
            rtb_url.Text = "";
            // 
            // rtb_detail
            // 
            rtb_detail.Font = new Font("Segoe UI", 10F);
            rtb_detail.Location = new Point(73, 159);
            rtb_detail.Name = "rtb_detail";
            rtb_detail.Size = new Size(846, 371);
            rtb_detail.TabIndex = 11;
            rtb_detail.Text = "";
            // 
            // bttn_get
            // 
            bttn_get.Font = new Font("Segoe UI", 12F);
            bttn_get.Location = new Point(743, 48);
            bttn_get.Name = "bttn_get";
            bttn_get.Size = new Size(176, 53);
            bttn_get.TabIndex = 10;
            bttn_get.Text = "GET";
            bttn_get.UseVisualStyleBackColor = true;
            bttn_get.Click += bttn_get_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(992, 578);
            Controls.Add(rtb_url);
            Controls.Add(rtb_detail);
            Controls.Add(bttn_get);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox rtb_url;
        private RichTextBox rtb_detail;
        private Button bttn_get;
    }
}
