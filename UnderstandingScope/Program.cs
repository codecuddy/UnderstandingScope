using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingScope
{
    class Program
    {
        private static string k = "";

        static void Main(string[] args)
        {
            string j = "";
            for (int i = 0; i < 10; i++)
            {
                j = i.ToString();
                k = i.ToString();
                Console.WriteLine(i);

                if (i == 9)
                {
                    string l = i.ToString();
                }
                //Console.WriteLine(l); l was defind inside the if statement can't call it outside
            }
            //Console.Write(i);   outside of the block, won't work
            Console.WriteLine("Outside of the for j: " + j); // j was defined outside of the for loop so can't be accessed outside
            Console.WriteLine("Outside of the for k: " + k);

            HelpersMethod();

            Car myCar = new Car();
            myCar.DoSomething();

            Console.ReadLine();

        }

        static void HelpersMethod()
        {
            Console.WriteLine("Value of k from the HelperMethod() k: " + k);
        }
    }

    class Car
    {
        public void DoSomething()
        {
            Console.WriteLine(helperMethod());
        }

        private string helperMethod()
        {
            return "You have a new car!";
        }
    }
}
