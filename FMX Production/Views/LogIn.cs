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
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
        

       

        private void btnLogIn_Click(object sender, EventArgs e)
        {

            DataAcess dataAcess = new DataAcess() ;
            Form1 home = new Form1();
            if(dataAcess.logIn(tbUserName.Text.Trim(), tbPassword.Text.Trim()))
            {
                home.userLogin();
                home.Show();
                this.Hide();
            }
            else
            {
                lblLogInError.Text = "Incorrect Username or Password";
                tbPassword.Clear();
                tbUserName.Clear();
                
            }
            
        }
    }
}
