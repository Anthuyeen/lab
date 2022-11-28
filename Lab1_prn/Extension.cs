using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_prn
{
    internal static class Extension
    {
        public static void Display(this Student e)
        {
            if (!(e is null))
                Console.WriteLine(e.ToString());
        }
    }
}
