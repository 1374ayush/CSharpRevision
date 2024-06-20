using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Test
{
      public class BaseClass
    {
        //protected elements will be accessible in base class or the derived class ,object of any of the class can not call it directly in another class
        protected int protectedField = 10;

        protected void ProtectedMethod()
        {
            Console.WriteLine("Protected method in BaseClass.");
        }
    }

    public class DerivedClass : BaseClass
    {
        public void AccessProtectedMembers()
        {
            // Accessing protected member of the base class
            Console.WriteLine($"Protected Field: {protectedField}");
            ProtectedMethod();
        }
    }
}
