using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class BLLExpenseDetails : BLLIncomeDetails
    {
        public int ExpenseId;
        public string ExpenseItem;
        public float ExpenseAmount;
        public string ExpenseDescription;
        public DateTime ExpenseDate;
        public int AddExpenseDetails()
        {
            DALExpenseDetails con = new DALExpenseDetails();
            con.ExpenseAmount = this.ExpenseAmount;
            con.ExpenseDescription = this.ExpenseDescription;
            con.ExpenseItem = this.ExpenseItem;
            con.PayModeId = this.PayModeId;
            con.CategoryId = this.CategoryId;
            con.TypeId = this.TypeId;
            con.ExpenseDate = this.ExpenseDate;
            int RowsEffected = con.AddExpense();
            return RowsEffected;

        }
        public DataSet ShowExpenseDetails()
        {
            DALExpenseDetails con = new DALExpenseDetails();
            DataSet ds = con.ShowExpenseInfo();
            return ds;
        }
        public int GetAllExpense()
        {
            DALExpenseDetails con = new DALExpenseDetails();
            int RowsEffected = con.GetTotalExpense();
            return RowsEffected;
        }
        public int GetTodayTotalExpense()
        {
           DALExpenseDetails con=new DALExpenseDetails();
            int RowsEffected = con.GetTodayTotalExpense();
            return RowsEffected;
        }
        public int GetMonthlyTotalExpense()
        {
            DALExpenseDetails con = new DALExpenseDetails();
            int RowsEffected = con.GetMonthlyTotalExpense();
            return RowsEffected;
        }
        public int GetYearlyTotalExpense()
        {
            DALExpenseDetails con = new DALExpenseDetails();
            int RowsEffected = con.GetYearlyTotalExpense();
            return RowsEffected;
        }
    }
}
