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
using FMX_Production.Controllers;


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
            DialogResult = DialogResult.Cancel;
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {

            DataAcess dataAcess = new DataAcess();
            if (dataAcess.logIn(tbUserName.Text.Trim(), tbPassword.Text.Trim()))
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                lblLogInError.Text = "Incorrect Username or Password";
                tbPassword.Clear();
                tbUserName.Clear();

            }

        }

        private void tbPassword_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
