using System;
using System.Collections.Generic;
using System.Text;
//Anand Jayaraman
namespace SingleTonPattern
{
    public sealed class SingleTon
    {
        private static int counter;
        private static readonly object obj = new object();
        //Changed the constructor to private to control the instantiation.
        private static SingleTon Instance = null;
        public int SingleTonValue = 0;

        public static SingleTon GetInstance
        {
            get
            {
                //Double check locking with instance check null before lock and after.
                if (Instance == null)
                {
                    lock (obj)
                    {
                        if (Instance == null)
                            Instance = new SingleTon();
                    }
                }
                return Instance;

            }
        }
       
        
    private SingleTon()
        {
            counter++;
            SingleTonValue = 0;
            Console.WriteLine("Shopping Cart Single Instance kicked off " + counter.ToString());
    
        }
        public void Display(string Msg)
        {
            Console.WriteLine(Msg);
        }
    }
}
