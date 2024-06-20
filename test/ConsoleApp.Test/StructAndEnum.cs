using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Test
{
    internal class StructAndEnum
    {
        public void method() {
            myStruct obj = new myStruct();
           // obj.method1();
           // Console.WriteLine(obj.method1(1));
            Console.WriteLine(myEnu.xy);
        }
    }

    public enum myEnu:int
    {
        xy=10,
        y , 
        z
    }

    public interface IStruct { }

    public struct myStruct
    {
        public delegate void myDele();    
        public string name { get; set; }

        public void method1() {
            Console.WriteLine("I am from struct");
            Console.WriteLine(myEnu.xy);
        
        }
        public dynamic method1(dynamic s)
        {
            myDele obj = new myDele(method1);
            obj.Invoke();

            return 10;
        }

    }

    //structures can only inherit interfaces.
    public interface newIn
    {

    }

    public struct newStruct:newIn
    {

    }

}
