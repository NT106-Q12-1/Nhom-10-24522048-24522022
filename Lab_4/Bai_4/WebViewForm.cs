using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2.WinForms;

namespace Bai_4
{
    public partial class WebViewForm : Form
    {
        private WebView2 web;
        public WebViewForm(string url)
        {
            InitializeComponent();

            this.Text = url;
            this.Width = 1100;
            this.Height = 800;

            web = new WebView2 { Dock = DockStyle.Fill };
            this.Controls.Add(web);

            this.Load += async (s, e) =>
            {
                if (web.CoreWebView2 == null)
                    await web.EnsureCoreWebView2Async();

                web.Source = new Uri(url);
            };
        }
    }
}
