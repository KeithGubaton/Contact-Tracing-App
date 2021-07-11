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
    public partial class Administrator : Form
    {
        public Administrator()
        {
            InitializeComponent();
            txtPass.PasswordChar = '*';
        }

        private void Administrator_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "admin" && txtPass.Text == "@Qwerty123")
            {
                this.Hide();
                Form2 logS = new Form2();
                logS.Show();
            }
            else
            {
                txtUsername.Clear();
                txtPass.Clear();
                ErrorMessage.Text = "Incorrect Username/Password. Please try again.";
            }
        }
    }
}
