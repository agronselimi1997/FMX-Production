using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using FMX_Production.Controllers;

namespace FMX_Production.Views
{
    public partial class AddEmploye : Form
    {
        public AddEmploye()
        {
            InitializeComponent();
        }
        DataAcess da = new DataAcess();


        private void AddEmploye_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void resetForm()
        {
            tbEmployeEmail.Clear();
            tbEmployeName.Clear();
            tbEmployePhoneNumber.Clear();
            tbEmployeSurname.Clear();
            chbIsCameraman.Checked = false;
            chbIsDronist.Checked = false;
            chbIsFlycamist.Checked = false;
            chbIsPhotograph.Checked = false;
            chbIsKranist.Checked = false;
        }


        private void btnAddWorker_Click(object sender, EventArgs e)
        {
            //kto kum testirat databazen 
            string name = tbEmployeName.Text;
            string surname = tbEmployeSurname.Text;
            string email = tbEmployeEmail.Text;
            string phonenumber = tbEmployePhoneNumber.Text;
            bool isPhorograph = chbIsPhotograph.Checked;
            bool isCameraman = chbIsCameraman.Checked;
            bool isDronist = chbIsDronist.Checked;
            bool isKranist = chbIsKranist.Checked;
            bool isFlycamist = chbIsFlycamist.Checked;
            if (da.addEmployeToDb(name, surname, email, phonenumber, isPhorograph, isCameraman, isDronist, isKranist, isFlycamist))
            {
                resetForm();
                lblErrorMessage.Text = "Me sukses !";


            }
            else
            {
                MessageBox.Show("There was an error while adding the employe", "ok", MessageBoxButtons.OK);
                resetForm();

            }
        }

        private void tbEmployeName_TextChanged(object sender, EventArgs e)
        {
            lblErrorMessage.Text = "";
        }
    }
}
