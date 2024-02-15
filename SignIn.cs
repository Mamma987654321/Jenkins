using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WelcomeApp
{
    public class SignIn
    {
        public string Authenticate(string userName, string password)
        {
            string msg;
            if(string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
            {
                msg = "User name and [assword requred";
            }
            else
            {
                if((userName == "admin") && (password == "admin@123")){

                    msg = "Authentication Pass";
                }
                else
                {
                    msg = "Authemtication Fail";
                }

            }
            return msg;
        }
    }
}
