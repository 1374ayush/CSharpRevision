using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Test
{
    internal class refAndOut
    {
        public void anothermethod(ref int a)
        {
            a = 10;
        }

        public void anothermethod2(out int b)
        {
            b = 10;
        }
        public void method()
        {
            int a = 20, c;
            anothermethod(ref a);
            Console.WriteLine(a);

            anothermethod2(out c);
            Console.WriteLine(c);

            anothermethod2(out int b);
            Console.WriteLine(b);
        }
    }
}
