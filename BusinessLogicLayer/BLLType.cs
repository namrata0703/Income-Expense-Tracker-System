using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class BLLType
    {
        public int TypeId;
        public string TypeName;
        public int GetAllTypeId()
        {
            DALType con = new DALType();
            con.TypeName = this.TypeName;
            int RowsEffected = con.GetAllTypeId();
            return RowsEffected;
        }
        public List<String> GetAllTypeName()
        {
            DALType con= new DALType();
            return con.GetAllTypeName();
        }
    }
}
