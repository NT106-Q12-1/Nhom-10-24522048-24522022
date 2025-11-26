using System.Net;

namespace Bai_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            string url = txtURL.Text.Trim();
            string savePath = txtFile.Text.Trim();

            if (url == "" || savePath == "")
            {
                MessageBox.Show("Please enter url and file path!");
                return;
            }

            try
            {
                WebClient myClient = new WebClient();

                // take content and save to file
                myClient.DownloadFile(url, savePath);

                // download content and show in RichTextBox
                Stream response = myClient.OpenRead(url);
                StreamReader reader = new StreamReader(response);
                string htmlContent = reader.ReadToEnd();

                rtbContent.Text = htmlContent;

                reader.Close();
                response.Close();

                MessageBox.Show("SUCCESS!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }
    }
}
