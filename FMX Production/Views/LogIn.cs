using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FMX_Production.Views;

namespace FMX_Production.Views
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuestLogIn_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            btnGuestLogIn.Enabled = false; 
            this.Hide();
            
        }
    }
}
