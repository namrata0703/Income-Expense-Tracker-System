using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class BLLCategoryDetails : BLLPaymentMode
    {
        public int CategoryId;
        public string ResourceName;
        public int AddCetegory()
        {
            DALCategoryDetails con = new DALCategoryDetails();
            con.ResourceName = this.ResourceName;
            con.TypeId = this.TypeId;
            int RowsEffected = con.AddCetegoryDetails();
            return RowsEffected;
        }
        public DataSet ShowCategoryDetails()
        {
            DALCategoryDetails con= new DALCategoryDetails();
            DataSet ds = con.ShowCetegoryInfo();
            return ds;
        }
        public List<String> GetAllCategoryName()
        {
            DALCategoryDetails con=new DALCategoryDetails();
            return con.GetAllCategory();
        }
        public int GetAllCetegoryId()
        {
            DALCategoryDetails con = new DALCategoryDetails();
            con.ResourceName = this.ResourceName;
            int RowsEffected = con.GetAllCetegoryId();
            return RowsEffected;
        }
    }
}
