using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    interface Interface1
    {
        string DEV1(string firstname, string lastname, string middleinitial);
    }

    class AddNew : Interface1
    {
        public string DEV1(string firstname, string lastname, string middleinitial)
        {
            string DevResult = firstname + " " + lastname + " " + middleinitial + " ";
            return DevResult;
                
        }
    }
}
