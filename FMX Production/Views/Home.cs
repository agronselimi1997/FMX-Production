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
namespace FMX_Production
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            guestLogin();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void guestLogin()
        {
            btnAddEmploye.Enabled = false;
            btnCreateOffer.Enabled = false;
            btnDeleteWeeding.Enabled = false;
            btnDeleteWorker.Enabled = false;
            btnConfirmWeeding.Enabled = false;
            btnAddEquipment.Enabled = false;
            btnCacnelWeeding.Enabled = false;
            btnAddWeeding.Enabled = false;
            btnCreateTeam.Enabled = false;
        }

       

        public void userLogin()
        {
            btnAddEmploye.Enabled = true;
            btnCreateOffer.Enabled = true;
            btnDeleteWeeding.Enabled = true;
            btnDeleteWorker.Enabled = true;
            btnConfirmWeeding.Enabled = true;
            btnAddEquipment.Enabled = true;
            btnCacnelWeeding.Enabled = true;
            btnAddWeeding.Enabled = true;
            btnCreateTeam.Enabled = true;
        }
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            
            logIn.Show();
            this.Hide();
        }

        private void btnAddEmploye_Click(object sender, EventArgs e)
        {
            AddEmploye add = new AddEmploye();
            add.Show();
            
            
        }

        private void btnAddEquipment_Click(object sender, EventArgs e)
        {
            AddEquipment addEquipment = new AddEquipment();
            addEquipment.Show();
        }
    }
}
