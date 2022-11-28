using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_prn
{
    internal static class List
    {
        public static void Display(this List<Student> std, string mess)
        {
            Console.WriteLine(mess);
            foreach (Student e in std)
                Console.WriteLine(e);
        }
    }
}
