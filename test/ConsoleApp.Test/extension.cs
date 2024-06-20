using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Test
{
    public delegate T addVal<T>(T b, T a);
    internal class extension
    { 
        
        public void method()
        {
            
          myClass1 obj = new myClass1();
            /*Console.WriteLine( obj.myMethod(10)); */
            /*
                        Func<int, int, int> funcMethod = new Func<int, int, int>(obj.add);
                        funcMethod += obj.add2;

                        Predicate<string> predicat = new Predicate<string>(obj.add3);

                        addVal funMethod = new addVal(obj.add);
                        int val = funMethod.Invoke(10, 30);*/

            addVal<int> vari = delegate (int a, int b)
            {
                return a + b;
            };

            //Console.WriteLine(vari(3, 4));

            obj.add4(vari);
        }
    }

    public class myClass1{
        public int add(int a, int b) {  return a + b; }
        public int add2(int a, int b) { return a + b; }

        public bool add3(string a) { return true;}

        public void add4(addVal<int> vari)
        {
            dynamic a;
            a = 10;
            Console.WriteLine("passing anonymous");
            Console.WriteLine(vari(3, 4));
        }
    }

    public static class myClass2 { 
        public static int myMethod(this myClass1 obj, int x)
        {
            Console.WriteLine("Hello I am extended"+x);
            return x;
        }
    }
}

