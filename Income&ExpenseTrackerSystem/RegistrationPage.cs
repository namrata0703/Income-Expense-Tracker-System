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
    public partial class RegistrationPage : Form
    {
        public RegistrationPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserRegistration();
        }
        private void UserRegistration()
        {
           BLLUserDetails con = new BLLUserDetails();
            con.UserName = txtBoxUserNameRegistration.Text;
            con.UserEmail = txtBoxUserEmailRegistration.Text;
            con.UserPhoneNumber = txtBoxPhoneNoRegistration.Text;
            con.UserPassword = txtBoxPasswordRegistration.Text;
            con.UserPassword = txtBoxConfrimPasswordReg.Text;
            if (Validation.CheckName(txtBoxUserNameRegistration.Text))
            {
                if (Validation.CheckEmail(txtBoxUserEmailRegistration.Text))
                {
                    if (Validation.CheckPhoneNumber(txtBoxPhoneNoRegistration.Text))
                    {
                        if (Validation.CheckPassword(txtBoxPasswordRegistration.Text))
                        {
                            if (txtBoxPasswordRegistration.Text == txtBoxConfrimPasswordReg.Text)
                            {
                                int RowsEffected = con.UserRegistrationInformation();
                                if (RowsEffected > 0)
                                {
                                    MessageBox.Show("Registration Successful!");

                                }
                                else
                                {
                                    MessageBox.Show("Registration Unsccessful!");
                                }
                            }
                        }
                        else
                        {
                            lblAlertPasswordRegistration.Text = "Give Right Password!";
                            lblAlertPasswordRegistration.ForeColor = Color.Red;

                        }
                    }
                    else
                    {
                        lblAlertPhoneNumberRegistration.Text = "Enter Valid Phone Number";
                        lblAlertPhoneNumberRegistration.ForeColor = Color.Red;
                    }
                }
                else
                {
                    lblAlertUserEmailRegistration.Text = "Enter Valid Email";
                    lblAlertUserEmailRegistration.ForeColor = Color.Red;
                }

            }
            else
            {
                lblAlertUserNameRegistration.Text = "Enter User Name";
                lblAlertUserNameRegistration.ForeColor = Color.Red;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LogInPage logInPage = new LogInPage();
            logInPage.Show();
            this.Hide();
        }

        private void lblCrossRegistrationFrom_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
