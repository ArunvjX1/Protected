using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protected.com.checking
{
    class test
    {
        protected string name;
    }

    class display : test
    {
        public void victory(string n)
        {
            name = n;   
            Console.WriteLine(name);
            Console.ReadLine();

        }
    }
    internal class testing
    {
    }
}
