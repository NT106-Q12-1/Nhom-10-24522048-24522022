using System.Net;

namespace Bai_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bttn_get_Click(object sender, EventArgs e)
        {
            WebRequest req = WebRequest.Create(rtb_url.Text);
            WebResponse res = req.GetResponse();
            Stream data = res.GetResponseStream();
            StreamReader sr = new StreamReader(data);
            rtb_detail.Text = sr.ReadToEnd();
            res.Close();
        }
    }
}
