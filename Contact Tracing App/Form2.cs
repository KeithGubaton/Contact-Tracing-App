using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contact_Tracing_App
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            txtHistory.Multiline = true;
            txtHistory.ScrollBars = ScrollBars.Both;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            String[] file = Directory.GetFiles(".", "Data_*");
            int i = 0;
            string createDate = "";
            while (i<file.Length)
            {
                string filename = file[i];
                filename = filename.Replace(".\\Data_", "");
                filename = filename.Replace(".txt", "");
                i++;

                if (SearchBox.Text == filename)
                {
                    createDate = filename;
                    filename = createDate;
                }
            }

            StreamReader inputFile;
            inputFile = File.OpenText("Data_" + createDate + ".txt");
            txtHistory.Text = inputFile.ReadToEnd();
            inputFile.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Administrator admin = new Administrator();
            admin.Show();
        }
    }
}
