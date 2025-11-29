using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_4
{
    public partial class BookTicket : Form
    {
        private string TenPhim;

        public BookTicket(string tenPhim)
        {
            tenPhim = tenPhim;
            InitializeComponent();
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            string tenKH = txtTenKH.Text.Trim();
            string sdt = txtSDT.Text.Trim();
            string email = txtEmail.Text.Trim();
            int soluong = (int)numsoluong.Value;
            string loaive = cboloaive.SelectedItem.ToString();

            if (string.IsNullOrEmpty(tenKH) || string.IsNullOrEmpty(sdt))
            {
                MessageBox.Show("Vui lòng nhập tên và số điện thoại khách hàng.");
                return;
            }

            //vì không đăng nhập/đăng kí nên không thấy giá vé trên web, giả sử giá vé chuẩn là 100000 VND
            int giaVeChuan = 100000;
            int giaVe = loaive switch
            {
                "Vé vớt" => giaVeChuan / 4,
                "Vé thường" => giaVeChuan,
                "Vé VIP" => giaVeChuan * 2,
                _ => giaVeChuan
            };

            int thanhTien = giaVe * soluong;

            string info = $"Đặt vé thành công!\n\n" +
                          $"Khách hàng: {tenKH}\nSĐT: {sdt}\nEmail: {email}\n" +
                          $"Phim: {TenPhim}\nLoại vé: {loaive}\nSố lượng: {soluong}\n" +
                          $"Thành tiền: {thanhTien:N0} VND";

            MessageBox.Show(info, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void BookTicket_Load(object sender, EventArgs e)
        {
            cboloaive.Items.Add("Vé vớt");
            cboloaive.Items.Add("Vé thường");
            cboloaive.Items.Add("Vé VIP");
            cboloaive.SelectedIndex = 1; // mặc định là vé thường

            numsoluong.Minimum = 1;
            numsoluong.Maximum = 10;
            numsoluong.Value = 1;
        }
    }
}
