using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Income_ExpenseTrackerSystem
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void lblCrossMainFrom_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {

        }

        private void btnExpense_Click(object sender, EventArgs e)
        {
            ExpensePage ep = new ExpensePage();
            ep.MdiParent = this;
            ep.Show();
        }

        private void btnIncome_Click(object sender, EventArgs e)
        {
            IncomePage ip=new IncomePage();
            ip.MdiParent = this;
            ip.Show();
        }

        private void btnAddCatagory_Click(object sender, EventArgs e)
        {
            CategoryPage cp=new CategoryPage();
            cp.MdiParent = this;
            cp.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            DashBoardPage dbp = new DashBoardPage();
            dbp.MdiParent = this;
            dbp.Show();
        }
    }
}
