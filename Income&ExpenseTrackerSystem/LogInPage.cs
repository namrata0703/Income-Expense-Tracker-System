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
using DataAccessLayer;

namespace Income_ExpenseTrackerSystem
{
    public partial class LogInPage : Form
    {
        public LogInPage()
        {
            InitializeComponent();
        }

        private void btnSubmitLogin_Click(object sender, EventArgs e)
        {
            UserLoginInfo();
        }
        public void UserLoginInfo()
        {
            BLLUserDetails con = new BLLUserDetails();
            con.UserName = txtBoxUserNameLogin.Text;
            con.UserPassword = txtBoxPasswordlogin.Text;
            if (Validation.CheckName(txtBoxUserNameLogin.Text))
            {
                if (Validation.CheckPassword(txtBoxPasswordlogin.Text))
                {
                    int rows = con.UserLogInInformation();
                    if (rows > 0)
                    {
                        MessageBox.Show("LogIn Succesful");
                       MainPage mainPage = new MainPage();
                        mainPage.Show();
                    }
                    else
                    {
                        MessageBox.Show("You have no account registration first.");
                    }
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistrationPage registrationPage = new RegistrationPage();
            registrationPage.Show();
            this.Hide();
        }

        private void btnForgatePassword_Click(object sender, EventArgs e)
        {
            ForgetPasswordPage forgetPasswordPage = new ForgetPasswordPage();
            forgetPasswordPage.Show();
        }

        private void lblCrossLoginFrom_Click(object sender, EventArgs e)
        {
            
            this.Hide();

        }
    }
}
