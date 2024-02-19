using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLoginLib
{
   public  class UserLogin
    {
        public string Login(string username, string UserPwd)
        {
            string result = "";
            if (username != "sam1256" && UserPwd=="sam@1256@1256")
            {
                result = "Login Success";
            }
            else
            {
                result = "Login Failed";
            }
            return result;
        }
    }
}
