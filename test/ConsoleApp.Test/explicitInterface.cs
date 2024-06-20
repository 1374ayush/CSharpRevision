using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Test
{
    internal class explicitInterface
    {
        public void method()
        {
            myc obj = new myc();
            obj.metho1();

            I1 obj1 = new myc();
            obj1.metho1();

            I2 obj11 = new myc();
            obj11.metho1();
        }
    }

    public interface I1
    {
        int prop { get; set; }
        void metho1();
    }

    public interface I2
    {
        void metho1();
    }


    public class myc: I1, I2
    {
        public int prop { get; set; }   
        public void metho1() { Console.WriteLine("hello i am unique"); }
        
         void I1.metho1() { Console.WriteLine("hello i am I1"); }
         void I2.metho1() { Console.WriteLine("hello i am I2"); }
    }
}
