using System;
using System.Windows.Forms;

namespace Add_MAss_File
{
    public partial class Form1 : Form
    {
        //public List<string> check()
        //{

        //}

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSearchPathToUploadTo_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.ShowDialog();
            txtFrom.Text = dialog.SelectedPath.Trim();

        }

        private void btnSearchPathToUploadFrom_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.ShowDialog();
            txtTo.Text = dialog.SelectedPath.Trim();

        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            string PathFrom = txtFrom.Text;
            string PathTo = txtTo.Text;
            AddImages.Add(PathFrom, PathTo);

        }

    }
}

