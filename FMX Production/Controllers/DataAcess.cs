using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using System.Data.SqlClient;


namespace FMX_Production.Controllers
{
    class DataAcess
    {
        
        
        public void addEmployeToDb(string name, string lastName, string email, string phoneNumber,
            bool isPhotoghraph, bool isKameraman, bool isDronist, bool iskranist, bool isFlycamist) {

        }
        public bool logIn(string username, string password)
        {
            SqlConnection con;
            con = new SqlConnection(@"Data Source=DESKTOP-A5LDB98;Initial Catalog=fmxProduction;Integrated Security=True");
            con.Open();
            //connection.Query($"SELECT * FROM USERS WHERE username = '" + username + "', and PASSWORD ='" + password + "'");
            string query = "select * from USERS where username = '" + username + "' and PASSWORD ='" + password + "'";
            SqlDataAdapter da = new SqlDataAdapter (query, con);
            DataTable dataTable = new DataTable();
            da.Fill(dataTable);
            if (dataTable.Rows.Count == 1)
            {
                return true;

            }
            else
                return false;
        }
    }
}
