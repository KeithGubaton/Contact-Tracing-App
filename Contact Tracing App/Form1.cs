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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtAge.Clear();
            txtContact.Clear();
            txtAddress.Clear();
            txtDate.Clear();
            txtTime.Clear();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            StreamWriter outputFile;

            String createDate = DateTime.Now.ToLongDateString();

            outputFile = File.AppendText("Data_" + createDate + ".txt");
            outputFile.WriteLine("Name:" + txtName.Text);
            outputFile.WriteLine("Age:" + txtAge.Text);
            outputFile.WriteLine("Address: " + txtAddress.Text);
            outputFile.WriteLine("Contact Number: " + txtContact.Text);
            outputFile.WriteLine("Date: " + txtDate.Text);
            outputFile.WriteLine("Time: " + txtTime.Text);
            outputFile.WriteLine("================================");
            outputFile.Close();

            this.Hide();
            TYMessage tY = new TYMessage();
            tY.Show();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 F2 = new Form2();
            F2.Show();
        }

        private void labelname_Click(object sender, EventArgs e)
        {

        }

        private void labelDate_Click(object sender, EventArgs e)
        {

        }

        private void labelage_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelAddress_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtContact_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
