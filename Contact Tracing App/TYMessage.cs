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
            labelMessage.Text = "You have contributed greatly in helping us " +
                                    "  monitor the ongoing pandemic! " +
                               "We wish you good health and stay safe always!";
            labelMessage.Font = new Font ("League Spartan", 14, FontStyle.Regular);
        }
    }
}
