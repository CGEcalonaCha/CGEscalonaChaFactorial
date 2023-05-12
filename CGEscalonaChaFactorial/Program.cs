using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGEscalonaChaFactorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(suma(7));
            Console.ReadLine();


        }
        public static int suma(int n)
        {

            if (n == 1)
            {
                return n;
            }
            else
            {
                return n + suma(n - 1);
            }


        }
    }
}
