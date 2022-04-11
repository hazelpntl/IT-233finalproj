using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    class LoginC
    {
        public string Log(string user, string pass)
        {
            string result = user + " " + pass;
            return result;
        }

    }

    class User1 : LoginC
    {

    }

    class User2 : LoginC
    {

    }
}
