using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Validation
    {
        public static bool CheckName(string Name)
        {
            if (Name == null || Name == string.Empty)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static bool CheckEmail(string Email)
        {
            if (CheckName(Email))
            {
                if (Email.Contains("@"))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public static bool CheckPhoneNumber(string PhoneNumber)
        {
            if (CheckName(PhoneNumber))
            {
                if (PhoneNumber.Length == 10)
                {
                    try
                    {
                        Convert.ToDouble(PhoneNumber);
                        return true;
                    }
                    catch (Exception ex)
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public static bool CheckPassword(string Password)
        {
            if (CheckName(Password))
            {
                if (Password.Length == 8)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

    }
}
