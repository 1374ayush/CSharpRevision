using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Test
{
    public sealed class mySealedClass<T>
    {
        public void sealedMethod()
        {
            Console.WriteLine("I am sealed");
        }

        public void seal(T data)
        {
            Console.WriteLine(data);
        }
    }
    internal class SealedClass
    {
        public void method()
        {
            mySealedClass<int> obj = new mySealedClass<int>();
            obj.sealedMethod();
            obj.seal(10);

            
        }
    }
}
