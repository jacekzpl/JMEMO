using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JMEMO.Models;

namespace JMEMO.Authentications
{
    public static class AuthenticateUser
    {
        static string Email = "user";
        static string Password = "pass";
        public static bool IsAuthenticatedUser(string token)
        {
            User user = new User();

            try
            {
                var textAsBytes = System.Convert.FromBase64String(token.Replace("Basic", "").Trim());
                string tokenText = Encoding.UTF8.GetString(textAsBytes);

                string[] ss = tokenText.Split(':');
                user.Email = ss[0];
                user.Password = ss[1];

                if (user.Email == Email && user.Password == Password)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch
            {
                return false;
            }
        }
    }
}
