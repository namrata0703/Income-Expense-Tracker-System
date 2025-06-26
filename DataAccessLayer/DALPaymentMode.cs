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
    public class DALPaymentMode : DALType
    {
        public int PayModeId { set; get; }
        public string PayModeType { set; get; }
        public int GetAllPayModeId()
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection connection = null;
            int RowsEffected = 0;
            try
            {
                connection = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("spGetPayModeId", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PayModeType", this.PayModeType);
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
        public List<string> GetAllPaymentTypeMode()
        {
            List<string> payments = null;
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection sqlConnection = null;
            try
            {
                sqlConnection = new SqlConnection(CS);
                SqlCommand sqlCommand = new SqlCommand("spGetAllPaymentMode", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlConnection.Open();
                SqlDataReader rdr = sqlCommand.ExecuteReader();
                payments = new List<string>();
                while (rdr.Read())
                {
                    payments.Add(rdr[0].ToString().Trim());
                }
                return payments;
            }
            catch (Exception ex) { return payments; }
            finally
            {
                sqlConnection.Close();

            }
        }
    }
}
