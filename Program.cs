using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple_Interface
{
  

interface IFirstInterface
    {
        void Display();
    }

    interface ISecondInterface
    {
        void Display();
    }

    class MyClass : IFirstInterface, ISecondInterface
    {
        void IFirstInterface.Display()
        {
            Console.WriteLine("First Interface:IFirstInterface");
        }

        void ISecondInterface.Display()
        {
            Console.WriteLine("Second Interface:Display from ISecondInterface");
        }
    }

    class Program
    {
        static void Main()
        {
            MyClass obj = new MyClass();
            ((IFirstInterface)obj).Display();
            ((ISecondInterface)obj).Display();
        }
    }

}

