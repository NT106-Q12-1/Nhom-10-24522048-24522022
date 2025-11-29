namespace Bai_4
{
    partial class BookTicket
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
            cboloaive = new ComboBox();
            numsoluong = new NumericUpDown();
            txtSDT = new TextBox();
            txtEmail = new TextBox();
            txtTenKH = new TextBox();
            lblLoaiVe = new Label();
            lblSoLuong = new Label();
            lblEmail = new Label();
            lblSDT = new Label();
            lblTenKH = new Label();
            btnBook = new Button();
            ((System.ComponentModel.ISupportInitialize)numsoluong).BeginInit();
            SuspendLayout();
            // 
            // cboloaive
            // 
            cboloaive.FormattingEnabled = true;
            cboloaive.Location = new Point(170, 169);
            cboloaive.Name = "cboloaive";
            cboloaive.Size = new Size(151, 28);
            cboloaive.TabIndex = 22;
            // 
            // numsoluong
            // 
            numsoluong.Location = new Point(170, 136);
            numsoluong.Name = "numsoluong";
            numsoluong.Size = new Size(150, 27);
            numsoluong.TabIndex = 21;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(170, 65);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(150, 27);
            txtSDT.TabIndex = 20;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(170, 97);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(150, 27);
            txtEmail.TabIndex = 19;
            // 
            // txtTenKH
            // 
            txtTenKH.Location = new Point(170, 32);
            txtTenKH.Name = "txtTenKH";
            txtTenKH.Size = new Size(150, 27);
            txtTenKH.TabIndex = 18;
            // 
            // lblLoaiVe
            // 
            lblLoaiVe.AutoSize = true;
            lblLoaiVe.Location = new Point(36, 177);
            lblLoaiVe.Name = "lblLoaiVe";
            lblLoaiVe.Size = new Size(57, 20);
            lblLoaiVe.TabIndex = 17;
            lblLoaiVe.Text = "Loại Vé";
            // 
            // lblSoLuong
            // 
            lblSoLuong.AutoSize = true;
            lblSoLuong.Location = new Point(36, 143);
            lblSoLuong.Name = "lblSoLuong";
            lblSoLuong.Size = new Size(24, 20);
            lblSoLuong.TabIndex = 16;
            lblSoLuong.Text = "SL";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(36, 104);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(46, 20);
            lblEmail.TabIndex = 15;
            lblEmail.Text = "Email";
            // 
            // lblSDT
            // 
            lblSDT.AutoSize = true;
            lblSDT.Location = new Point(36, 72);
            lblSDT.Name = "lblSDT";
            lblSDT.Size = new Size(36, 20);
            lblSDT.TabIndex = 14;
            lblSDT.Text = "SĐT";
            // 
            // lblTenKH
            // 
            lblTenKH.AutoSize = true;
            lblTenKH.Location = new Point(36, 39);
            lblTenKH.Name = "lblTenKH";
            lblTenKH.Size = new Size(56, 20);
            lblTenKH.TabIndex = 13;
            lblTenKH.Text = "Tên KH";
            // 
            // btnBook
            // 
            btnBook.Location = new Point(170, 203);
            btnBook.Name = "btnBook";
            btnBook.Size = new Size(94, 29);
            btnBook.TabIndex = 12;
            btnBook.Text = "Book";
            btnBook.UseVisualStyleBackColor = true;
            btnBook.Click += btnBook_Click;
            // 
            // BookTicket
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(380, 271);
            Controls.Add(cboloaive);
            Controls.Add(numsoluong);
            Controls.Add(txtSDT);
            Controls.Add(txtEmail);
            Controls.Add(txtTenKH);
            Controls.Add(lblLoaiVe);
            Controls.Add(lblSoLuong);
            Controls.Add(lblEmail);
            Controls.Add(lblSDT);
            Controls.Add(lblTenKH);
            Controls.Add(btnBook);
            Name = "BookTicket";
            Text = "BookTicket";
            Load += BookTicket_Load;
            ((System.ComponentModel.ISupportInitialize)numsoluong).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboloaive;
        private NumericUpDown numsoluong;
        private TextBox txtSDT;
        private TextBox txtEmail;
        private TextBox txtTenKH;
        private Label lblLoaiVe;
        private Label lblSoLuong;
        private Label lblEmail;
        private Label lblSDT;
        private Label lblTenKH;
        private Button btnBook;
    }
}