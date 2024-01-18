using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class3
    {
        [DllImport("kernel32.dll")]
        public static extern bool Beep(UInt32 frequency, UInt32 duration);
    }
}
