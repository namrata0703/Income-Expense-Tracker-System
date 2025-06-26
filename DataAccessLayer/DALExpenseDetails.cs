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
    public class DALExpenseDetails : DALIncomeDetails
    {
        public int ExpenseId { set; get; }
        public string ExpenseItem { set; get; }
        public float ExpenseAmount { set; get; }
        public string ExpenseDescription { set; get; }
        public DateTime ExpenseDate { set; get; }
        public int AddExpense()
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection con = null;
            int RowsEffected = 0;
            try
            {
                con = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("spAddExpenseDetails", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ExpenseAmount", this.ExpenseAmount);
                cmd.Parameters.AddWithValue("@ExpenseDescription", this.ExpenseDescription);
                cmd.Parameters.AddWithValue("@ExpenseItem", this.ExpenseItem);
                cmd.Parameters.AddWithValue("@PayModeId", this.PayModeId);
                cmd.Parameters.AddWithValue("@CetegoryId", this.CategoryId);
                cmd.Parameters.AddWithValue("@TypeId ", this.TypeId);
                cmd.Parameters.AddWithValue("@ExpenseDate", this.ExpenseDate);
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
        public DataSet ShowExpenseInfo()
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection con = null;
            DataSet ds = null;
            try
            {
                con = new SqlConnection(cs);
                SqlDataAdapter da = new SqlDataAdapter("spShowExpenseDetails", con);
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
        public int GetTotalExpense()
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection sqlConnection = null;
            int RowsEffected = 0;
            try
            {
                sqlConnection = new SqlConnection(cs);
                SqlCommand sqlCommand = new SqlCommand("spTotalExpense", sqlConnection);
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
        public int GetTodayTotalExpense()
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection sqlConnection = null;
            int RowsEffected = 0;
            try
            {
                sqlConnection = new SqlConnection(cs);
                SqlCommand sqlCommand = new SqlCommand("TodayTotalExpense", sqlConnection);
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
        public int GetMonthlyTotalExpense()
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection sqlConnection = null;
            int RowsEffected = 0;
            try
            {
                sqlConnection = new SqlConnection(cs);
                SqlCommand sqlCommand = new SqlCommand("spMonthlyTotalExpenseDetails", sqlConnection);
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
        public int GetYearlyTotalExpense()
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection sqlConnection = null;
            int RowsEffected = 0;
            try
            {
                sqlConnection = new SqlConnection(cs);
                SqlCommand sqlCommand = new SqlCommand("spYearlyTotalExpenseDetails", sqlConnection);
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
