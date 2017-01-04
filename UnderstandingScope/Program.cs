using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingScope
{
    class Program
    {
        private static string n = "";

        static void Main(string[] args)
        {
            string j = "";
            string m = "";
            for (int i = 0; i < 10; i++)
            {
                n = i.ToString();
                j = i.ToString();
                int k = i + 6;
                m = k.ToString();

                Console.WriteLine(i);

                if (i == 9)
                {
                    string l = i.ToString();
                }
                //Console.WriteLine(l); l was defind inside the if statement can't call it outside
                
            }
            //Console.Write(i);   outside of the block, won't work
            Console.WriteLine("Outside of the for j: " + j + 4); // j was defined outside of the for loop so can't be accessed outside
            Console.WriteLine("Outside of the for m: " + m);

            HelpersMethod();

            Car myCar = new Car();
            myCar.DoSomething();

            Console.ReadLine();

        }

        static void HelpersMethod()
        {
            Console.WriteLine("Value of n from the HelperMethod() n: " + n);
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
