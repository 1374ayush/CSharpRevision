using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Test
{
    public interface commonVehicle{ void method1();  }
    public class bus:commonVehicle
    {
        public void method1()
        {
            Console.WriteLine("I am bus");
        }
    }

    public class car:commonVehicle
    {
        public void method1()
        {
            Console.WriteLine("I am car");
        }
    }

    public class vehicle
    {
        public commonVehicle giveInstance(string type)
        {
            switch (type.ToLower())
            {
                case "car":
                    return new car();
                    break;
                case "bus":
                    return new bus();
                    break;
                default: return null;
            }
        }
    }


    internal class Factory
    {
        public void method()
        {
            vehicle obj = new vehicle();
            commonVehicle car = obj.giveInstance("car");
            car.method1();

            commonVehicle bus = obj.giveInstance("bus");
            bus.method1();

        }
    }
}
