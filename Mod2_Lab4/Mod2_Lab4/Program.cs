using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2_Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a while loop
            //we start with n = 1 
            //the condition check for the while, tests if n is less than 6 
            //if so the loop body code executes
            //inside the loop we output the value of n and then increment it by 1
            //once n = 6 the loop stops
            //pay attention to the output to see what the last value is to ensure you understand
            //how the evaluation of the condition is done and how the while loop executes

            int n = 1;
            while(n < 6)
            {
                Console.WriteLine($"Current value of n is {n}");
                n++;
            }
        }
    }
}
