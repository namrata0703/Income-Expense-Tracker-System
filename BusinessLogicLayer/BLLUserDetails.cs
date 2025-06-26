using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class BLLUserDetails : BLLExpenseDetails
    {
        public int UserId;
        public string UserName;
        public string UserEmail;
        public string UserPhoneNumber;
        public string UserPassword;
        public int UserRegistrationInformation()
        {
            DALUserDetails con = new DALUserDetails();
            con.UserName = this.UserName;
            con.UserEmail = this.UserEmail;
            con.UserPhoneNumber = this.UserPhoneNumber;
            con.UserPassword = this.UserPassword;
            int RowsEffected = con.UserRegistration();
            return RowsEffected;

        }
        public int UserLogInInformation()
        {
            DALUserDetails con = new DALUserDetails();
            con.UserName = this.UserName;
            con.UserPassword = this.UserPassword;
            int RowsEffected = con.UserLoginDeatils();
            return RowsEffected;
        }
        public int ForgetPasswordInfo()
        {
            DALUserDetails con = new DALUserDetails();
            con.UserName = this.UserName;
            con.UserPassword = this.UserPassword;
            int RowsEffected = con.ForgetPassword();
            return RowsEffected;
        }
    }
}
