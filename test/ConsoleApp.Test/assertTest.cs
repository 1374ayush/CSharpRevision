using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp.Test
{
    public class myclass
    {
        public static void mymethod(Object obj)
        {
            Console.WriteLine(obj);
        }
    }
    internal class assertTest
    {
        public void method()
        {
            /* int val = 21;
             Console.WriteLine("before assert block");
             Debug.Assert(true, "value should be 2");
             Console.WriteLine("after assert block");*/

            // myclass.mymethod(10);


            /*boxing-unboxing
            int a = 10;
            Object obj = a;

            int j = (int)obj;

            Console.WriteLine(j);*/

            Thread myThread = new Thread(myclass.mymethod);
            myThread.Start(12);
/*
            Console.WriteLine(Thread.CurrentThread + ": " + myThread.IsAlive); */


        }
        
    }
}
