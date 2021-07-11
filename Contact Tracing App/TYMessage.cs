using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contact_Tracing_App
{
    public partial class TYMessage : Form
    {
        public TYMessage()
        {
            InitializeComponent();
        }    

        private void TYMessage_Load(object sender, EventArgs e)
        {
            labelTY.Text = "thank you for filling out " +
            "\n \t this form!";
            labelTY.Font = new Font("League Spartan", 16, FontStyle.Regular);
            labelMessage.Text = "You have contributed greatly " +
                "\n in helping us monitor the " +
            "\n\t   ongoing pandemic! " +
            "\n\t We wish you good health" +
            "\n and stay safe always!";
            labelMessage.Font = new Font ("League Spartan", 14, FontStyle.Regular);
        }

        private void linkLabelNew_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form1 FillForm = new Form1();
            FillForm.Show();
        }

        private void linkLabelAdmin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Administrator admin = new Administrator();
            admin.Show();
        }
    }
}
