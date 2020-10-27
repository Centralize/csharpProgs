using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            double tal = 1;
            
            while (true)
            {
                Console.WriteLine(Convert.ToString(tal));
                tal++;
            }
        }
    }
}
