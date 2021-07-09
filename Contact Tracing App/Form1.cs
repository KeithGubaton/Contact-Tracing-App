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
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 F2 = new Form2();
            F2.Show();
            
            

           // while ( !inputFile.EndOfStream )
           // {
            //    MessageBox.Show(inputFile.ReadLine());
            //}
        }
    }
}
