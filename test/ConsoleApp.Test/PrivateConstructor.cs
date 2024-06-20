using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Test
{
    public class PrivateConstructor
    {
        /*private PrivateConstructor()
        {
        
        }*/
        public PrivateConstructor() { Console.WriteLine("base constructor"); }
        public PrivateConstructor(string name) { Console.WriteLine("another base constructor");  }

        public void method() { Console.WriteLine("Hello from private constructor class");  }
    }

    public class newClass:PrivateConstructor
    {
        public newClass(string name):base(name) { Console.WriteLine("child constructor");  }
    }
}
