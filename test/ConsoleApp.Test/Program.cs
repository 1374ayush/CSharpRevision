using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Test
{
    public class myClass
    {
        public delegate void myDelgate(string greeting);

        public event myDelgate myEvent;


        public void raiseEvent(string greeting)
        {
            myEvent?.Invoke(greeting);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Hello ji");

            myClass obj = new myClass();

            //attach a function with an event
            obj.myEvent += greetings;


            obj.raiseEvent("a good person !!!");*/


            //dexcription of ref and out keyword
            /*   Basics basics = new Basics();
               basics.method();*/

            /*  VarAndDynamic.name = "Piyush";

              VarAndDynamic obj2= new VarAndDynamic();
              VarAndDynamic obj3 = new VarAndDynamic();
              obj2.method();

              obj3.method();*/

            /* var obj = staticClass.method1("aman");
             obj.method2();

             var obj1 = staticClass.method1("any");
             obj1.method2();
 */
            /*
                        PrivateConstructor obj = new PrivateConstructor("Ayush");
                        Console.WriteLine(obj.GetType().Name);
                        obj.method();
            */

            /*  newClass obj = new newClass("ayush");*/

            /*    DerivedClass obj = new DerivedClass();
                obj.AccessProtectedMembers();*/

            /*BaseClass obj2 = new BaseClass();
            obj2.protectedField;//this will give error 

            
*/
            /*  HidingOverriding obj = new HidingOverriding();
              obj.mainMethod();   
  */
            /*
                        extension obj = new extension();
                        obj.method();*/

            /* StructAndEnum obj = new StructAndEnum();
             obj.method();*/

            /*assertTest obj = new assertTest();
            obj.method();*/

       /*     dsa dsaa = new dsa();
            dsaa.method();*/
/*
            Singleton singleton = new Singleton();
            singleton.method();*/
/*
            Factory factory = new Factory();
            factory.method();*/
/*
            AbstractFactory factory = new AbstractFactory();
            factory.method();*/

         /*   SealedClass ss = new SealedClass();
            ss.method();

*/

            /*explicitInterface obj = new explicitInterface();
            obj.method();*/

        /*    refAndOut obj = new refAndOut();
            obj.method();
*/

            queslogic obj = new queslogic();
            obj.method();

            Console.ReadKey();

        }

        static public void greetings(string msg)
        {
            Console.Write(msg);
        }
    }
}
