using HtmlAgilityPack;
using Microsoft.Web.WebView2.WinForms;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Security.Policy;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_4
{
    public partial class Form1 : Form
    {
        public class Phim
        {
            public string TenPhim { get; set; }
            public string LinkChiTiet { get; set; }
            public string Anh { get; set; }
        }

        private List<Phim> dsPhim = new List<Phim>();
        private WebView2 webView;

        public Form1()
        {
            InitializeComponent();

            webView = new WebView2
            {
                Visible = false
            };
            this.Controls.Add(webView);

            // DataGridView set up
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;

            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                progressBar1.Value = 0;
                dsPhim.Clear();
                dataGridView1.DataSource = null;

                // Khởi tạo WebView2 nếu chưa init
                if (webView.CoreWebView2 == null)
                    await webView.EnsureCoreWebView2Async();

                // tránh đăng ký nhiều lần
                webView.NavigationCompleted -= WebView_NavigationCompleted;
                webView.NavigationCompleted += WebView_NavigationCompleted;

                // Load trang
                webView.Source = new Uri("https://betacinemas.vn/phim.htm");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load phim: " + ex.Message);
            }
        }

        private async void WebView_NavigationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs e)
        {
            try
            {
                string script = @"
                    JSON.stringify(
                        Array.from(document.querySelectorAll('a[href^=""/chi-tiet-phim""]'))
                             .map(a => ({ 
                                TenPhim: a.innerText.trim(), 
                                LinkChiTiet: a.href,
                                Anh: a.querySelector('img')?.src 
                            }))
                    );";
                string json = await webView.ExecuteScriptAsync(script);
                json = System.Text.RegularExpressions.Regex.Unescape(json.Trim('"'));
                ParseJSON(json);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy dữ liệu phim: " + ex.Message);
            }
        }

        private async void ParseJSON(string json)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => ParseJSON(json)));
                return;
            }

            dsPhim.Clear();

            try
            {
                dsPhim = JsonConvert.DeserializeObject<List<Phim>>(json) ?? new List<Phim>();

                DataGridViewImageColumn imgCol = new DataGridViewImageColumn
                {
                    HeaderText = "Poster",
                    ImageLayout = DataGridViewImageCellLayout.Zoom,
                    Width = 150
                };
                dataGridView1.Columns.Add(imgCol);

                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "TenPhim",
                    HeaderText = "Tên Phim",
                    Width = 250
                });

                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "LinkChiTiet",
                    HeaderText = "Link",
                    Width = 300
                });

                DataGridViewButtonColumn btnCol = new DataGridViewButtonColumn
                {
                    HeaderText = "Đặt Vé",
                    Text = "Đặt vé",
                    UseColumnTextForButtonValue = true,
                    Width = 100
                };
                dataGridView1.Columns.Add(btnCol);

                dataGridView1.DataSource = dsPhim;

                // Load hình vào DataGridView
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    var phim = (Phim)row.DataBoundItem;
                    if (!string.IsNullOrEmpty(phim.Anh))
                    {
                        row.Cells[0].Value = await LoadImageAsync(phim.Anh);
                    }
                }

                // Lưu JSON ra file
                File.WriteAllText("phim.json", JsonConvert.SerializeObject(dsPhim, Formatting.Indented));

                progressBar1.Minimum = 0;
                progressBar1.Maximum = dsPhim.Count;
                progressBar1.Value = dsPhim.Count;

                MessageBox.Show($"Đã tải {dsPhim.Count} phim!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi parse JSON: " + ex.Message);
            }
        }

        private async Task<Image> LoadImageAsync(string url)
        {
            try
            {
                using HttpClient client = new HttpClient();
                var bytes = await client.GetByteArrayAsync(url);
                using var ms = new MemoryStream(bytes);
                return Image.FromStream(ms);
            }
            catch
            {
                return null;
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var phim = (Phim)dataGridView1.Rows[e.RowIndex].DataBoundItem;

            if (phim == null) return;

            if (dataGridView1.Columns[e.ColumnIndex].DataPropertyName == "LinkChiTiet")
            {
                if (!string.IsNullOrEmpty(phim.LinkChiTiet))
                {
                    WebViewForm xem = new WebViewForm(phim.LinkChiTiet);
                    xem.Show();
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dataGridView1.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                var phim = (Phim)dataGridView1.Rows[e.RowIndex].DataBoundItem;
                if (phim != null)
                {
                    BookTicket book = new BookTicket(phim.TenPhim);
                    book.Show();
                }
            }
        }
    }
}
