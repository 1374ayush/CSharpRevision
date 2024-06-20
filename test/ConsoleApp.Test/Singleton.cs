using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Test
{

    public class mySingletonClass
        //Can be used for configuration files , like a global configuration which is needed by all the elements of the application
    {
        private int valContainer;
        private mySingletonClass(int a) { valContainer = a;  }

        private static mySingletonClass instance = null;

        public static mySingletonClass InstanceMethod(int a)
        {
            if (instance == null)
            {
                instance = new mySingletonClass(a);
            }
            return instance;
        }

        public void getVal()
        {
            Console.WriteLine(valContainer);
        }

    }
    internal class Singleton
    {
        public void method()
        {
            mySingletonClass obj =  mySingletonClass.InstanceMethod(1);
            obj.getVal();

            mySingletonClass obj1 = mySingletonClass.InstanceMethod(10);
            obj1.getVal();
        }
    }
}
