using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Protected.com.checking;

namespace Protected
{
    internal class Program
    {
        static void Main(string[] args)
        {
            test t = new com.checking.test();
            display check = new com.checking.display();
            check.victory("Arun Vijay");
            Console.ReadLine();

        }
    }
}
