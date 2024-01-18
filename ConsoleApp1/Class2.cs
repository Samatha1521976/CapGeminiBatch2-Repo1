using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class2
    {
        [Obsolete]
        public void Function1()
        {
            Console.WriteLine("Function1");
        }

        public void Function2()
        {
            Console.WriteLine("Function2");
        }
    }
}
