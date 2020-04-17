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
        DataAcess da;
        
       
        private void AddEmploye_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
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
            da.addEmployeToDb(name, surname,email, phonenumber, isPhorograph, isCameraman, isDronist, isKranist , isFlycamist);
            
            
            
        }
    }
}
