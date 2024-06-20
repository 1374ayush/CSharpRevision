using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Test
{
    internal class VarAndDynamic
    {

        public static string name {  get; set; }   

        static int x = 10;
        static VarAndDynamic() {
            Console.WriteLine("from static constructor");
            x = 100;
        }

        public VarAndDynamic() {
            Console.WriteLine("from instance constructor");
            x = 121;
        }  
      /*  public void method3(dynamic a)
        {
            Console.WriteLine(a);
        }
        public void method3(int x)
        {
            Console.WriteLine(x);
        }*/

        public void method2()
        {
            /* var x = 20;
             dynamic y = 20;*/
            /*
                        Console.WriteLine("x = {0}, y = {1}", x, y);
                        //they cannot be used in function property or return type

                        y = "ssss";
                        Console.WriteLine("x = {0}, y = {1}", x, y);
            */
            /*Console.WriteLine(x.GetType());*/

            /*method3(30);*/
            Console.WriteLine(name);
            name = "Ayush";
            Console.WriteLine(name);
        }
        public void method()
        {
           /* Console.WriteLine(x);*/
            method2();
        }
    }
}
