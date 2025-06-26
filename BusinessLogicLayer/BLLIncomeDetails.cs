using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class BLLIncomeDetails: BLLCategoryDetails
    {
        public int IncomeId;
        public float IncomeAmount;
        public string IncomeDescription;
        public DateTime IncomeDate;
        public int AddIncomeInformation()
        {
            DALIncomeDetails con = new DALIncomeDetails();
            con.IncomeAmount = this.IncomeAmount;
            con.IncomeDescription = this.IncomeDescription;
            con.PayModeId = this.PayModeId;
            con.CategoryId = this.CategoryId;
            con.TypeId = this.TypeId;
            con.IncomeDate = this.IncomeDate;
            int RowsEffected = con.AddIncome();
            return RowsEffected;

        }
        public DataSet ShowIncomeDetails()
        {
            DALIncomeDetails con = new DALIncomeDetails();
            DataSet ds = con.ShowIncomeInfo();
            return ds;
        }
        public int GetAllIncome()
        {
            DALIncomeDetails con = new DALIncomeDetails();
            int RowsEffected = con.GetTotalIncome();
            return RowsEffected;
        }
        public int GetTodayTotalIncome()
        {
            DALIncomeDetails con = new DALIncomeDetails();
            int RowsEffected = con.GetTodayTotalIncome();
            return RowsEffected;
        }
        public int GetMonthlyTotalIncome()
        {
            DALIncomeDetails con = new DALIncomeDetails();
            int RowsEffected = con.GetMonthlyTotalIncome();
            return RowsEffected;
        }
        public int GetYearlyTotalIncome()
        {
            DALIncomeDetails con = new DALIncomeDetails();
            int RowsEffected = con.GetYearlyTotalIncome();
            return RowsEffected;
        }

    }
}
