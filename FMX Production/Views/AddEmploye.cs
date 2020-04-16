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

namespace FMX_Production.Views
{
    public partial class AddEmploye : Form
    {
        public AddEmploye()
        {
            InitializeComponent();
        }
        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter da;
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
            con = new SqlConnection(@"Data Source=DESKTOP-A5LDB98;Initial Catalog=fmxProduction;Integrated Security=True");
            con.Open();
            cmd = new SqlCommand("INSERT INTO Employes (Name, Surname, Email, Phonenumber, isPhotograph, isCameraman, isKranist, isDronist, isFlycamist) VALUES (@Name, @Surname, @Email, @Phonenumber, @isPhotograph, @isCameraman, @isKranist, @isDronist, @isFlycamist)", con);
            cmd.Parameters.AddWithValue("@Name", name);
            cmd.Parameters.AddWithValue("@Surname", surname);
            cmd.Parameters.AddWithValue("@Email", email);
            cmd.Parameters.AddWithValue("@Phonenumber", phonenumber);
            cmd.Parameters.AddWithValue("@isPhotograph", isPhorograph);
            cmd.Parameters.AddWithValue("@isCameraman", isCameraman);
            cmd.Parameters.AddWithValue("@isKranist", isKranist);
            cmd.Parameters.AddWithValue("@isDronist", isDronist);
            cmd.Parameters.AddWithValue("@isFlycamist", isFlycamist);
            cmd.ExecuteNonQuery();
            
        }
    }
}
