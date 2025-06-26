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
    public partial class CategoryPage : Form
    {
        public CategoryPage()
        {
            InitializeComponent();
        }

        private void CategoryPage_Load(object sender, EventArgs e)
        {
            LoadcategoryNameAndPaymentTypeNameAndTypeName();
        }
        private void LoadcategoryNameAndPaymentTypeNameAndTypeName()
        {
            BLLExpenseDetails conn = new BLLExpenseDetails();
            List<string> typeNames = conn.GetAllTypeName();

            
            comboBoxType.Items.Clear();

            foreach (string type in typeNames)
            {
                comboBoxType.Items.Add(type);
            }
        }
        public int GetAllTypeId()
        {
            BLLType connection = new BLLType();
            string TypeName = comboBoxType.Text;
            connection.TypeName = TypeName;
            int TypeId = connection.GetAllTypeId();
            return TypeId;

        }
        public void AddCetegoryInfo()
        {
            int TypeId = GetAllTypeId();
            BLLCategoryDetails con = new BLLCategoryDetails();
            con.ResourceName = txtBoxCatagory.Text;
            con.TypeId = TypeId;
            int RowsEffected = con.AddCetegory();
            if (RowsEffected > 0)
            {
                MessageBox.Show("Add Successful!");
            }
            else
            {
                MessageBox.Show("Error!!");
            }
        }
        public void ShowCategoryDetails()
        {
            BLLCategoryDetails con = new BLLCategoryDetails();
            DataSet ds = con.ShowCategoryDetails();
            if (ds != null)
            {
                dataGridViewCatagoriesList.Show();
                BindingSource source = new BindingSource();
                source.DataSource = ds.Tables[0];
                dataGridViewCatagoriesList.DataSource = source;
            }
        }

        private void btnAddOnCatagory_Click(object sender, EventArgs e)
        {
            AddCetegoryInfo();
            ShowCategoryDetails();
        }

        private void lblCrossCatagoryFrom_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
