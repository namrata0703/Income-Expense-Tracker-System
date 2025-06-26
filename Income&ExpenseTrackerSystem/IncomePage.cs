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
    public partial class IncomePage : Form
    {
        public IncomePage()
        {
            InitializeComponent();
        }

        private void IncomePage_Load(object sender, EventArgs e)
        {
            LoadcategoryNameAndPaymentTypeNameAndTypeName();
        }
        private void LoadcategoryNameAndPaymentTypeNameAndTypeName()
        {
            BLLIncomeDetails conn = new BLLIncomeDetails();
            List<string> categoryNames = conn.GetAllCategoryName();
            List<string> paymentTypes = conn.GetAllPaymentTypeName();
            List<string> typeNames = conn.GetAllTypeName();

            comboBoxCatagoeyInIncome.Items.Clear();
            comboBoxPayModeType.Items.Clear();
            comboBoxTypeOnIncome.Items.Clear();

            foreach (string categoryName in categoryNames)
            {
                comboBoxCatagoeyInIncome.Items.Add(categoryName);
            }
            foreach (string paymentType in paymentTypes)
            {
                comboBoxPayModeType.Items.Add(paymentType);
            }
            foreach (string type in typeNames)
            {
                comboBoxTypeOnIncome.Items.Add(type);
            }
        }

        private void btnAddOnIncome_Click(object sender, EventArgs e)
        {
            AddIncomeInfo();
            ShowIncomeInformation();
        }
        public void ShowIncomeInformation()
        {
            BLLIncomeDetails con = new BLLIncomeDetails();
            DataSet ds = con.ShowIncomeDetails();
            if (ds != null)
            {
                dataGridViewIncomeList.Show();
                BindingSource source = new BindingSource();
                source.DataSource = ds.Tables[0];
                dataGridViewIncomeList.DataSource = source;
            }
        }
        public void AddIncomeInfo()
        {
            int TypeId = GetAllTypeId();
            int PayModeId = GetAllPayModeId();
            int CategoryId = GetAllCetegoryId();
            BLLIncomeDetails con = new BLLIncomeDetails();
            con.IncomeAmount = (float)Convert.ToDouble(txtBoxIncomeAmount.Text);
            con.IncomeDescription = txtBoxDescriptionIncome.Text;
            con.TypeId = TypeId;
            con.PayModeId = PayModeId;
            con.CategoryId = CategoryId;
            con.IncomeDate = Convert.ToDateTime(dateTimePickerIncome.Text);
            int RowsEffected = con.AddIncomeInformation();
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
            string TypeName = comboBoxTypeOnIncome.Text;
            connection.TypeName = TypeName;
            int TypeId = connection.GetAllTypeId();
            return TypeId;

        }
        public int GetAllPayModeId()
        {
            BLLPaymentMode connection = new BLLPaymentMode();
            string PayModeType = comboBoxPayModeType.Text;
            connection.PayModeType = PayModeType;
            int PayModeId = connection.GetAllPayModeId();
            return PayModeId;
        }
        public int GetAllCetegoryId()
        {
            BLLCategoryDetails connection = new BLLCategoryDetails();
            string ResourceName = comboBoxCatagoeyInIncome.Text;
            connection.ResourceName = ResourceName;
            int IncomeExpenseId = connection.GetAllCetegoryId();
            return IncomeExpenseId;

        }

        private void lblCrossIncomeFrom_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
