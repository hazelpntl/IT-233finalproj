using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    abstract class Class1
    {
        public abstract string ViewRecs(string firstname, string lastname, string middleinitial);
        
    }

    class User_Hazel : Class1
    {
        public override string ViewRecs(string firstname, string lastname, string middleinitial)
        {
            string RecsResult =  "Developer 1.0 -- " + firstname + " " + lastname + " " + middleinitial + " ";
            return RecsResult;
        }
    }

    class User_Karen : Class1
    {
        public override string ViewRecs(string firstname, string lastname, string middleinitial)
        {
            string RecsResult = "Developer 2.0 -- " + firstname + " " + lastname + " " + middleinitial + " ";
            return RecsResult;
        }
    }
}
