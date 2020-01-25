using System;
using System.Threading.Tasks;
//Anand Jayaraman
namespace SingleTonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Parallel.Invoke(
                ()=>ShoppingCart1(),
                ()=>ShoppingCart2());

            Console.WriteLine("Time To Terminate?");
        }

        private static void ShoppingCart2()
        {
            SingleTon obj2 = SingleTon.GetInstance;
            obj2.SingleTonValue = 2;
            obj2.Display("From Shopping Cart 2 " + "Shared Property value " + obj2.SingleTonValue.ToString());
        }

        private static void ShoppingCart1()
        {
            SingleTon obj1 = SingleTon.GetInstance;
            obj1.SingleTonValue = 1;
            obj1.Display("From Shopping Cart 1 " + "Shared Property value " + obj1.SingleTonValue.ToString());
        }
    }
}
