using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Test
{
    internal class HidingOverriding
    {
       public void mainMethod()
        {
            derivedClass obj = new derivedClass();
            obj.method();

            baseClass obj2= new derivedClass();    
            obj2.method();

            baseClass obj3 = new derivedClass2();
            obj3.method();
        }
    }

    public class baseClass
    {
        public virtual void method() { Console.WriteLine("Hello base method"); }
    }

    public class derivedClass:baseClass
    {
        public new void method() { Console.WriteLine("Hello derived method"); }
    }

    public class derivedClass2 : baseClass
    {
        public override void method() {
            try
            {
                Console.WriteLine("GC Maximum Generations:" + GC.MaxGeneration);
            }
            catch (Exception oEx)
            {
                Console.WriteLine("Error:" + oEx.Message);
            }

        }
    }
}
