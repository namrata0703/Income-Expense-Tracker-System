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
    public class DALIncomeDetails : DALCategoryDetails
    {
        public int IncomeId { set; get; }
        public float IncomeAmount { set; get; }
        public string IncomeDescription { set; get; }
        public DateTime IncomeDate { set; get; }
        public int AddIncome()
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection con = null;
            int RowsEffected = 0;
            try
            {
                con = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("spInsertIncomeDetails", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IncomeAmount", this.IncomeAmount);
                cmd.Parameters.AddWithValue("@IncomeDescription", this.IncomeDescription);
                cmd.Parameters.AddWithValue("@PayModeId", this.PayModeId);
                cmd.Parameters.AddWithValue("@CetegoryId", this.CategoryId);
                cmd.Parameters.AddWithValue("@TypeId ", this.TypeId);
                cmd.Parameters.AddWithValue("@IncomeDate", this.IncomeDate);
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
        public DataSet ShowIncomeInfo()
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection con = null;
            DataSet ds = null;
            try
            {
                con = new SqlConnection(cs);
                SqlDataAdapter da = new SqlDataAdapter("spShowIncomeDetails", con);
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
        public int GetTotalIncome()
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection sqlConnection = null;
            int RowsEffected = 0;
            try
            {
                sqlConnection = new SqlConnection(cs);
                SqlCommand sqlCommand = new SqlCommand("spTotalIncome", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlConnection.Open();
                RowsEffected = Convert.ToInt32(sqlCommand.ExecuteScalar());
                return RowsEffected;
            }
            catch (Exception ex)
            {
                return RowsEffected;
            }
            finally
            {
                sqlConnection.Close();
            }
        }
        public int GetTodayTotalIncome()
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection sqlConnection = null;
            int RowsEffected = 0;
            try
            {
                sqlConnection = new SqlConnection(cs);
                SqlCommand sqlCommand = new SqlCommand("spTodayTotalIncome", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlConnection.Open();
                RowsEffected = Convert.ToInt32(sqlCommand.ExecuteScalar());
                return RowsEffected;
            }
            catch (Exception ex)
            {
                return RowsEffected;
            }
            finally
            {
                sqlConnection.Close();
            }
        }
        public int GetMonthlyTotalIncome()
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection sqlConnection = null;
            int RowsEffected = 0;
            try
            {
                sqlConnection = new SqlConnection(cs);
                SqlCommand sqlCommand = new SqlCommand("spMonthlyTotalIncomeDetails", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlConnection.Open();
                RowsEffected = Convert.ToInt32(sqlCommand.ExecuteScalar());
                return RowsEffected;
            }
            catch (Exception ex)
            {
                return RowsEffected;
            }
            finally
            {
                sqlConnection.Close();
            }
        }
        public int GetYearlyTotalIncome()
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection sqlConnection = null;
            int RowsEffected = 0;
            try
            {
                sqlConnection = new SqlConnection(cs);
                SqlCommand sqlCommand = new SqlCommand("spYearlyTotalIncomeDetails", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlConnection.Open();
                RowsEffected = Convert.ToInt32(sqlCommand.ExecuteScalar());
                return RowsEffected;
            }
            catch (Exception ex)
            {
                return RowsEffected;
            }
            finally
            {
                sqlConnection.Close();
            }
        }

    }
}
