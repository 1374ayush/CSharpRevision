using System;

namespace ConsoleApp.Test
{
    public class Basics
    {
        public void method2(int val1)
        {
            val1 *= 10;
            Console.WriteLine(val1);
        }

        public void method2(ref int val1)
        {
            val1 *= 100;
        }
       public void method()
        {
            int val1 = 1;
            int val2 ;   

            Console.WriteLine("value before ref/out");
            Console.WriteLine(val1);
          

            //method2(ref val1, out val2);
            method2(ref val1);
            method2(val1);

            Console.WriteLine("value after ref/out");
            Console.WriteLine(val1);
        }
    }
}