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
    public class DALType
    {
        public int TypeId { set; get; }
        public string TypeName { set; get; }
        public int GetAllTypeId()
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection connection = null;
            int RowsEffected = 0;
            try
            {
                connection = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("spAllGetTypeId", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TypeName", this.TypeName);
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
        public List<string> GetAllTypeName()
        {
            List<string> typeNames = null;
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection sqlConnection = null;
            try
            {
                sqlConnection = new SqlConnection(CS);
                SqlCommand sqlCommand = new SqlCommand("spGetAllTypeNames", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlConnection.Open();
                SqlDataReader rdr = sqlCommand.ExecuteReader();
                typeNames = new List<string>();
                while (rdr.Read())
                {
                    typeNames.Add(rdr[0].ToString().Trim());
                }
                return typeNames;
            }
            catch (Exception ex) { return typeNames; }
            finally
            {
                sqlConnection.Close();

            }
        }
    }
}
