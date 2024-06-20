using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Test
{
    public interface IButton { void button(); }
    public interface ICheckBox { void checkBox(); }

    public class macButton : IButton
    {
        public void button()
        {
            Console.WriteLine("Mac Button");
        }
    }

    public class macCheckBox : ICheckBox
    {
        public void checkBox()
        {
            Console.WriteLine("Mac checkBox");
        }
    }

    public class windowsButton : IButton
    {
        public void button()
        {
            Console.WriteLine("Windows Button");
        }
    }

    public class windowsCheckBox : ICheckBox
    {
        public void checkBox()
        {
            Console.WriteLine("Windows checkBox");
        }
    }

    public interface IGUiFactory 
    { 
       IButton getButton();
       ICheckBox getCheckBox();    
    
    }
    public class MacOs:IGUiFactory
    {
        public IButton getButton() { return new macButton(); }
        public ICheckBox getCheckBox() {  return new macCheckBox(); }
    }


    public class Windows : IGUiFactory
    {
        public IButton getButton() { return new windowsButton(); }
        public ICheckBox getCheckBox() { return new windowsCheckBox(); }
    }

    public class Application
    {
        private IGUiFactory _factory;
        public Application(IGUiFactory factory) { _factory = factory; }

        public void callMethods()
        {
            _factory.getButton().button();
            _factory.getCheckBox().checkBox();
        }

    }


   
    internal class AbstractFactory
    {
        public void method()
        {
            // we have a button and a check box
            //both are different for windows and macOS

            //our user will only interact with the Application class ,and he will only give the preference , elese every thing will be handled bys us

            Application obj;

            string type = Console.ReadLine();
            switch (type.ToLower())
            {
                case "mac":
                    obj = new Application(new MacOs());
                    break;

                case "windows":
                    obj = new Application(new Windows());
                    break;
                default: 
                    obj = null; 
                    break;
            }

            obj.callMethods();  
        }
    }
}
