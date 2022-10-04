using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoopAndForEachLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //initialization;condition;increment/decrement//
            for (int a = 20; a < 31; a++)
            {
                if(a==24)
                {
                    break;//when we apply break it gives until we get a==5 value or if we apply continue skip the initional value and rest of the values will appear//
                }
                Console.WriteLine(a);
            }

            string[] bikes = new string[4];//array name is bikes
            bikes[0] = "hero";
            bikes[1] = "honda";
            bikes[2] = "suzuki";
            bikes[3] = "tvs";

            int[] oddnumbers = new int[5];
            oddnumbers[0] = 1;
            oddnumbers[1] = 3;
            oddnumbers[2] = 5;
            oddnumbers[3] = 7;
            oddnumbers[4] = 9;

            foreach (string bike in bikes)
            {
                Console.WriteLine(bike);
            }

            foreach (int oddnumber in oddnumbers)
            {
                Console.WriteLine(oddnumber);
            }

            Console.ReadLine();
        }
    }
}
