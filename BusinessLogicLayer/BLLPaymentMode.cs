using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class BLLPaymentMode : BLLType
    {
        public int PayModeId;
        public string PayModeType;
        public int GetAllPayModeId()
        {
            DALPaymentMode con = new DALPaymentMode();
            con.PayModeType = this.PayModeType;
            int RowsEffected = con.GetAllPayModeId();
            return RowsEffected;
        }
        public List<String> GetAllPaymentTypeName()
        {
           DALPaymentMode con= new DALPaymentMode();
            return con.GetAllPaymentTypeMode();
        }
    }
}
