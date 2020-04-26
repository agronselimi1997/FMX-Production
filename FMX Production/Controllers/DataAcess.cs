using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using System.Data.SqlClient;
using FMX_Production.Models;

namespace FMX_Production.Controllers
{
    class DataAcess
    {
        public bool addEmployeToDb(string name, string lastName, string email, string phoneNumber,
            bool isPhotoghraph, bool isKameraman, bool isDronist, bool iskranist, bool isFlycamist)
        {
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
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }

        }
        public bool editCamera(int id, string name, bool isHD, bool is4K)
        {
            string connectionString = Helper.CnnVal("fmxproductionDB");
            try
            {
            using(SqlConnection con =  new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("dbo.spEditCamera", con))
                {
                       cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                        cmd.Parameters.Add("@model", SqlDbType.VarChar).Value = name;
                        cmd.Parameters.Add("@isHD", SqlDbType.Bit).Value = isHD;
                        cmd.Parameters.Add("@is4K", SqlDbType.Bit).Value = is4K;
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        return true;

                }
            }
            }catch(SqlException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }

        }
        
        public bool editEmploye(int id, string name, string lastName, string email, string phoneNumber,
           bool isPhotoghraph, bool isKameraman, bool isDronist, bool iskranist, bool isFlycamist)
        {
            string connectionString = Helper.CnnVal("fmxproductionDB");
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("dbo.spEditEmployeById", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                        cmd.Parameters.Add("@EmployeName", SqlDbType.VarChar).Value = name;
                        cmd.Parameters.Add("@surname", SqlDbType.VarChar).Value = lastName;
                        cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
                        cmd.Parameters.Add("@phoneNumber", SqlDbType.VarChar).Value = phoneNumber;
                        cmd.Parameters.Add("@isPhotograph", SqlDbType.Bit).Value = isPhotoghraph;
                        cmd.Parameters.Add("@isKameraman", SqlDbType.Bit).Value = isKameraman;
                        cmd.Parameters.Add("@isKransit", SqlDbType.Bit).Value = iskranist;
                        cmd.Parameters.Add("@isDronist", SqlDbType.Bit).Value = isDronist;
                        cmd.Parameters.Add("@isFlycamist", SqlDbType.Bit).Value = isFlycamist;
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();

                    }
                }

                return true;
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }

        }
        public List<Camera> getCameras()
        {
            using (IDbConnection connection = new SqlConnection(Helper.CnnVal("fmxproductionDB")))
            {
                var ou = connection.Query<Camera>("select * from Cameras").ToList();
                return ou;

            }

        }
        public bool logIn(string username, string password)
        {
            SqlConnection con;
            con = new SqlConnection(Helper.CnnVal("fmxproductionDB"));
            con.Open();
            //connection.Query($"SELECT * FROM USERS WHERE username = '" + username + "', and PASSWORD ='" + password + "'");
            string query = "select * from USERS where username = '" + username + "' and PASSWORD ='" + password + "'";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
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
        public List<Equipment> getEquipment()
        {
            using (IDbConnection connection = new SqlConnection(Helper.CnnVal("fmxproductionDB")))
            {
                var ou = connection.Query<Equipment>("select * from Equipments").ToList();
                return ou;
            }
        }
        public void deleteEmployeById(int id)
        {
            using (IDbConnection connection = new SqlConnection(Helper.CnnVal("fmxproductionDB")))
            {
                connection.Query("delete from Employes where Id = '" + id + "'");
            }
        }

        public bool addEquipment(string name, string lensSerial, bool isDron, bool isKran, bool isPhotoAparat, bool isFlycam, int cmeraID, bool isOther)
        {
            try
            {
                SqlConnection con = new SqlConnection(Helper.CnnVal("fmxproductionDB"));
                con.Open();
                string query = "insert into Equipments (Name, LensSerial, isDron, isKran, isPhotoAparat, isFlycam, CameraID, isOther)";
                query += " values('" + name + "','" + lensSerial + "','" + isDron + "','" + isKran + "','" + isPhotoAparat + "','" + isFlycam + "','" + cmeraID + "','" + isOther + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);

                return false;
            }

        }


        public bool addCamera(string name, bool isHD, bool is4K)
        {
            try
            {
                SqlConnection con = new SqlConnection(Helper.CnnVal("fmxproductionDB"));
                con.Open();
                string query = "insert into Cameras (Name, is4K, isHD)";
                query += " values('" + name + "','" + is4K + "','" + isHD + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }

        }

    }
}
