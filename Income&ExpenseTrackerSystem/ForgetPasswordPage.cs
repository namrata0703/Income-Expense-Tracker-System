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
    public partial class ForgetPasswordPage : Form
    {
        public ForgetPasswordPage()
        {
            InitializeComponent();
        }

        private void btnLogInForgetPassword_Click(object sender, EventArgs e)
        {
            ForgetPasswordInformation();
        }
        public void ForgetPasswordInformation()
        {
            BLLUserDetails con = new BLLUserDetails();
            con.UserName = txtBoxUserNameForgetPassword.Text;
            con.UserPassword = txtBoxNewPasswordForgetPassword.Text;
            con.UserPassword = txtBoxConfrimPasswordForgetPassword.Text;
            if (txtBoxUserNameForgetPassword.Text != string.Empty)
            {
                if (txtBoxNewPasswordForgetPassword.Text != string.Empty)
                {
                    if (txtBoxConfrimPasswordForgetPassword.Text != string.Empty)
                    {
                        if (txtBoxNewPasswordForgetPassword.Text == txtBoxConfrimPasswordForgetPassword.Text)
                        {
                            int RowsEffected = con.ForgetPasswordInfo();
                            if (RowsEffected > 0)
                            {
                                MessageBox.Show("Password Change Succesfully!");
                            }
                            else
                            {
                                MessageBox.Show("Error!");
                            }
                        }
                    }
                    else
                    {
                        lblAlertConfrimPasswordForget.Text = "Enter Confrim Password";
                    }
                }
                else
                {
                    lblAlertNewPassword.Text = "Enter Your New Password";
                }
            }
            else
            {
                lblAlertUserNameForgetPassword.Text = "Enter Your Name";
            }
        }

        private void btnLogInForgot_Click(object sender, EventArgs e)
        {
            LogInPage logInPage = new LogInPage();
            logInPage.Show();
        }

        private void lblCrossForgetPasswordFrom_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
