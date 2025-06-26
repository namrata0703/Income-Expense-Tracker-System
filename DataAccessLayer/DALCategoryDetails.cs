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
    public class DALCategoryDetails : DALPaymentMode
    {
        public int CategoryId { set; get; }
        public string ResourceName { set; get; }
        public int AddCetegoryDetails()
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection connection = null;
            int RowsEffected = 0;
            try
            {
                connection = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("spAddCategory", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ResourceName", this.ResourceName);
                cmd.Parameters.AddWithValue("@TypeId", this.TypeId);
                connection.Open();
                RowsEffected = cmd.ExecuteNonQuery();
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
        public int GetAllCetegoryId()
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection connection = null;
            int RowsEffected = 0;
            try
            {
                connection = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("spGetIncomeExpenseId", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ResourceName", this.ResourceName);
                connection.Open();
                RowsEffected = Convert.ToInt32(cmd.ExecuteScalar());
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
        public List<string> GetAllCategory()
        {
            List<string> categories = null;
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection sqlConnection = null;
            try
            {
                sqlConnection = new SqlConnection(CS);
                SqlCommand sqlCommand = new SqlCommand("spGetAllResourceCategoryName", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlConnection.Open();
                SqlDataReader rdr = sqlCommand.ExecuteReader();
                categories = new List<string>();
                while (rdr.Read())
                {
                    categories.Add(rdr[0].ToString().Trim());
                }
                return categories;
            }
            catch (Exception ex) { return categories; }
            finally
            {
                sqlConnection.Close();

            }
        }
        public DataSet ShowCetegoryInfo()
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection con = null;
            DataSet ds = null;
            try
            {
                con = new SqlConnection(cs);
                SqlDataAdapter da = new SqlDataAdapter("spShowCetegoryDetails", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                return ds;
            }
            finally
            {
                con.Close();
            }
        }
    }
}
