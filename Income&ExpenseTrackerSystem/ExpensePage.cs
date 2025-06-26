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
    public partial class ExpensePage : Form
    {
        public ExpensePage()
        {
            InitializeComponent();
        }

        private void ExpensePage_Load(object sender, EventArgs e)
        {
            LoadcategoryNameAndPaymentTypeNameAndTypeName();
        }
        private void LoadcategoryNameAndPaymentTypeNameAndTypeName()
        {
            BLLExpenseDetails conn = new BLLExpenseDetails();
            List<string> categoryNames = conn.GetAllCategoryName();
            List<string> paymentTypesNames = conn.GetAllPaymentTypeName();
            List<string> typeNames = conn.GetAllTypeName();

            comboBoxCatagoeyIdInExpense.Items.Clear();
            comboBoxPayModeTypeInExpense.Items.Clear();
            comboBoxTypeInExpense.Items.Clear();

            foreach (string categoryName in categoryNames)
            {
                comboBoxCatagoeyIdInExpense.Items.Add(categoryName);
            }
            foreach (string paymentType in paymentTypesNames)
            {
                comboBoxPayModeTypeInExpense.Items.Add(paymentType);
            }
            foreach (string type in typeNames)
            {
                comboBoxTypeInExpense.Items.Add(type);
            }
        }

        private void btnAddOnExpense_Click(object sender, EventArgs e)
        {
            AddExpenseInfo();
            ShowExpenseInformation();
        }
        public void ShowExpenseInformation()
        {
            BLLExpenseDetails con = new BLLExpenseDetails();
            DataSet ds = con.ShowExpenseDetails();
            if (ds != null)
            {
                dataGridViewExpenseList.Show();
                BindingSource source = new BindingSource();
                source.DataSource = ds.Tables[0];
                dataGridViewExpenseList.DataSource = source;
            }
        }
        public void AddExpenseInfo()
        {
            int TypeId = GetAllTypeId();
            int PayModeId = GetAllPayModeId();
            int CategoryId = GetAllCetegoryId();
            BLLExpenseDetails con = new BLLExpenseDetails();
            con.ExpenseAmount = (float)Convert.ToDouble(txtBoxExpense.Text);
            con.ExpenseDescription = txtBoxDescriptionExpense.Text;
            con.ExpenseItem = txtBoxItemExpense.Text;
            con.TypeId = TypeId;
            con.PayModeId = PayModeId;
            con.CategoryId = CategoryId;
            con.ExpenseDate = Convert.ToDateTime(dateTimePickerExpense.Text);
            int RowsEffected = con.AddExpenseDetails();
            if (RowsEffected > 0)
            {
                MessageBox.Show("Add Successful");
            }
            else
            {
                MessageBox.Show("Error!");
            }

        }
        public int GetAllTypeId()
        {
            BLLType connection = new BLLType();
            string TypeName = comboBoxTypeInExpense.Text;
            connection.TypeName = TypeName;
            int TypeId = connection.GetAllTypeId();
            return TypeId;

        }
        public int GetAllPayModeId()
        {
           BLLPaymentMode connection = new BLLPaymentMode();
            string PayModeType = comboBoxPayModeTypeInExpense.Text;
            connection.PayModeType = PayModeType;
            int PayModeId = connection.GetAllPayModeId();
            return PayModeId;
        }
        public int GetAllCetegoryId()
        {
            BLLCategoryDetails connection = new BLLCategoryDetails();
            string ResourceName = comboBoxCatagoeyIdInExpense.Text;
            connection.ResourceName = ResourceName;
            int IncomeExpenseId = connection.GetAllCetegoryId();
            return IncomeExpenseId;

        }

        private void lblCrossForgetPasswordFrom_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
