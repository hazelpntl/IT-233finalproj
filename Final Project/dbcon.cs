using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    class dbcon
    {
        public static string connection = System.IO.File.ReadAllText(System.Environment.CurrentDirectory + @"\configure.jer");
    }
}
