using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JMEMO.Validations
{
    public static class ValidateUser
    {
        public static bool Email(string email )
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}
