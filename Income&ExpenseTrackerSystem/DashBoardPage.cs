using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer;

namespace Income_ExpenseTrackerSystem
{
    public partial class DashBoardPage : Form
    {
        public DashBoardPage()
        {
            InitializeComponent();
        }

        private void btnShowTotalIncome_Click(object sender, EventArgs e)
        {
            TotalIncome();
        }
        public void TotalIncome()
        {
            BLLIncomeDetails con = new BLLIncomeDetails();
            int totalIncome = con.GetAllIncome();
            lblShowTotalIncome.Text = totalIncome.ToString();
        }

        private void btnShowTotalExpense_Click(object sender, EventArgs e)
        {
            TotalExpense();
        }
        public void TotalExpense()
        {
            BLLExpenseDetails con = new BLLExpenseDetails();
            int totalExpense = con.GetAllExpense();
            lblShowTotalExpense.Text = totalExpense.ToString();
        }

        private void lblCrossForgetPasswordFrom_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void btnShowTodayIncome_Click(object sender, EventArgs e)
        {
            TodayTotalIncome();
        }
        public void TodayTotalIncome()
        {
            BLLIncomeDetails con = new BLLIncomeDetails();
            int todaytotalIncome = con.GetTodayTotalIncome();
            lblTodayIncome.Text = todaytotalIncome.ToString();
        }

        private void btnShowYeasterdayIncome_Click(object sender, EventArgs e)
        {

        }

        private void btnShowMonthlyIncome_Click(object sender, EventArgs e)
        {
            MonthlyTotalIncome();
        }
        public void MonthlyTotalIncome()
        {
            BLLIncomeDetails con = new BLLIncomeDetails();
            int monthlytotalIncome = con.GetMonthlyTotalIncome();
            lblMonthlyIncome.Text = monthlytotalIncome.ToString();
        }

        private void btnShowYearlyIncome_Click(object sender, EventArgs e)
        {
            YearlyTotalIncome();
        }
        public void YearlyTotalIncome()
        {
            BLLIncomeDetails con = new BLLIncomeDetails();
            int yearlytotalIncome = con.GetYearlyTotalIncome();
            lblYearlyInocme.Text = yearlytotalIncome.ToString();
        }

        private void btnShowTodayExpense_Click(object sender, EventArgs e)
        {
            TodayTotalExpense();
        }
        public void TodayTotalExpense()
        {
            BLLExpenseDetails con = new BLLExpenseDetails();
            int todaytotalExpense = con.GetTodayTotalExpense();
            lblTodayExpense.Text = todaytotalExpense.ToString();
        }

        private void btnShowYeasterdayExpense_Click(object sender, EventArgs e)
        {

        }

        private void btnShowMonthlyExpense_Click(object sender, EventArgs e)
        {
            MonthlyTotalExpense();
        }
        public void MonthlyTotalExpense()
        {
            BLLExpenseDetails con = new BLLExpenseDetails();
            int monthlytotalExpense = con.GetMonthlyTotalExpense();
            lblMonthlyExpense.Text = monthlytotalExpense.ToString();
        }

        private void btnShowYearlyExpense_Click(object sender, EventArgs e)
        {
            YearlyTotalExpense();
        }
        public void YearlyTotalExpense()
        {
            BLLExpenseDetails con = new BLLExpenseDetails();
            int yearlytotalExpense = con.GetYearlyTotalExpense();
            lblMonthlyExpense.Text = yearlytotalExpense.ToString();
        }

    }
}
