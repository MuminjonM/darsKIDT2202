using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace darsKIDT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 24, b = 36;
            
            while(a!=b)
            {
                if (a > b) a -= b;
                else
                    b -= a;
            }

            Console.WriteLine("ekub= " + a);
            Console.ReadKey();
        }
    }
}
