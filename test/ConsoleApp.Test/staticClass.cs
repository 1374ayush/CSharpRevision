using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Test
{
    public class instanceClass
    {
        public string name;
        public void method2()
        {
            Console.WriteLine(name);
        }
        public instanceClass(string name)
        {
            this.name = name;
        }  

    }

    public static class staticClass
    {
        public static instanceClass instance { get; set; } = null;

        public static instanceClass method1(string val)
        {
            if (instance == null)
            {
                instance = new instanceClass(val);
            }
             return instance;
        }
    }
}
