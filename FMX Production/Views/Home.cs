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
namespace FMX_Production
{
    public partial class Form1 : Form
    {
        DataAcess DataAcess = new DataAcess();
        List<Employe> employes = new List<Employe>();

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
        void fillEmployes()
        {
            employes = DataAcess.getAllEmployes();

            lbWorkers.DataSource = employes;
            lbWorkers.DisplayMember = "fullinfo";

        }

        public void userLogin()
        {
            fillEmployes();

            btnAddEmploye.Enabled = true;
            btnCreateOffer.Enabled = true;
            btnDeleteWeeding.Enabled = true;
            if (lbWorkers.Items.Count == 0)
            {
                btnDeleteWorker.Enabled = false;
            } 
            else
            {
                btnDeleteWorker.Enabled = true;
            }

            btnConfirmWeeding.Enabled = true;
            btnAddEquipment.Enabled = true;
            btnCacnelWeeding.Enabled = true;
            btnAddWeeding.Enabled = true;
            btnCreateTeam.Enabled = true;
            btnLogIn.Text = "Log Out";  
        }

        public void userLogout()
        {
            btnAddEmploye.Enabled = false;
            btnCreateOffer.Enabled = false;
            btnDeleteWeeding.Enabled = false;
            if (lbWorkers.Items.Count == 0)
            {
                btnDeleteWorker.Enabled = false;
            }

            btnConfirmWeeding.Enabled = false;
            btnAddEquipment.Enabled = false;
            btnCacnelWeeding.Enabled = false;
            btnAddWeeding.Enabled = false;
            btnCreateTeam.Enabled = false;
            btnLogIn.Text = "Log In";

            lbWorkers.DataSource = null;
            lbWorkers.Items.Clear();
        }


        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (btnLogIn.Text.Equals("Log In"))
            {
                LogIn logIn = new LogIn();
                if (logIn.ShowDialog(this) == DialogResult.OK)
                {
                    userLogin();
                }

            }
            else if (btnLogIn.Text.Equals("Log Out"))
            {
                userLogout();
            }

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

        private void btnDeleteWorker_Click(object sender, EventArgs e)
        {

            Employe employe = lbWorkers.SelectedItem as Employe;
            DataAcess.deleteEmployeById(employe.getId());
            fillEmployes();

        }

        private void lbWorkers_DoubleClick(object sender, EventArgs e)
        {
            if (lbWorkers.SelectedItem != null)
            {
                MessageBox.Show("Emloye Iinformation Here", "Information!", MessageBoxButtons.OK);
            }
        }
    }
}
