using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DALUserDetails : DALExpenseDetails
    {
        public int UserId { set; get; }
        public string UserName { set; get; }
        public string UserEmail { set; get; }
        public string UserPhoneNumber { set; get; }
        public string UserPassword { set; get; }
        public int UserRegistration()
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection con = null;
            int RowsEffected = 0;
            try
            {
                con = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("spUserRegistration", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UserName", this.UserName);
                cmd.Parameters.AddWithValue("@UserEmail", this.UserEmail);
                cmd.Parameters.AddWithValue("@UserPhoneNumber", this.UserPhoneNumber);
                cmd.Parameters.AddWithValue("@UserPassword", this.UserPassword);
                con.Open();
                RowsEffected = cmd.ExecuteNonQuery();
                return RowsEffected;
            }
            catch (Exception ex)
            {
                return RowsEffected;
            }
            finally
            {
                con.Close();
            }

        }

        public int UserLoginDeatils()
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection con = null;
            int RowsEffected = 0;
            try
            {
                con = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("spUserLogInInDetails", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UserName", this.UserName);
                cmd.Parameters.AddWithValue("@UserPassword", this.UserPassword);
                con.Open();
                RowsEffected = Convert.ToInt32(cmd.ExecuteScalar());
                return RowsEffected;
            }
            catch (Exception ex)
            {
                return RowsEffected;
            }
            finally
            {
                con.Close();
            }
        }

        public int ForgetPassword()
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection connection = null;
            int RowsEffected = 0;
            try
            {
                connection = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("spForgetPassword", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UserName", this.UserName);
                cmd.Parameters.AddWithValue("@UserPassword", this.UserPassword);
                connection.Open();
                RowsEffected =Convert.ToInt32(cmd.ExecuteNonQuery());
                return RowsEffected;

            }
            catch (Exception ex)
            {
                return RowsEffected;
            }
            finally
            {
                connection.Close();
            }
        }


    }
}
