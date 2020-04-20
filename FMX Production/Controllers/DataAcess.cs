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
       


        public bool addEmployeToDb(string name, string lastName, string email, string phoneNumber,
            bool isPhotoghraph, bool isKameraman, bool isDronist, bool iskranist, bool isFlycamist) {
            try
            {
                SqlConnection con = new SqlConnection(Helper.CnnVal("fmxproductionDB"));
                con.Open();
                string query = "insert into Employes (Name, Surname, Email, Phonenumber, isPhotograph,isCameraman, isKranist, isDronist, isFlycamist)";
                query += " values('" + name + "','" + lastName + "','" + email + "','" + phoneNumber + "','" + isPhotoghraph + "','" + isKameraman + "','" + iskranist + "','" + isDronist + "','" + isFlycamist + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            } catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
           


        }
        public bool logIn(string username, string password)
        {
            SqlConnection con;
            con = new SqlConnection(Helper.CnnVal("fmxproductionDB"));
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
        public List<Employe> getAllEmployes()
        {
           
            using (IDbConnection connection = new SqlConnection(Helper.CnnVal("fmxproductionDB")))
            {
                var ou = connection.Query<Employe>("select * from Employes").ToList();
                return ou;
              
            }
        }
        public void deleteEmployeById (int id)
        {
            using (IDbConnection connection = new SqlConnection(Helper.CnnVal("fmxproductionDB")))
            {
                connection.Query("delete from Employes where Id = '" + id + "'");
            }
        }

    }
}
