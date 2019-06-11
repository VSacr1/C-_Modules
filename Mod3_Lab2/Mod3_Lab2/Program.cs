using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod3_Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
           // int first = 9;
           // int second = 0;
            //Console.WriteLine("Enter your first number: ");
            //first = System.Int32.Parse(Console.ReadLine());
            //Console.WriteLine("Enter second number: ");
            //second = System.Int32.Parse(Console.ReadLine());

            //int result = Divide(first, second);
            //Console.WriteLine($"The result of dividing {first} by {second} is {result}");
            string lastName = Console.ReadLine();
            Console.Write(lastName);
        }

        //Method Divide() accepts two integer arguments and returns the result
        //of dividing first by second
        //We do no validation of the arguments so a user may pass in a zero
        //in place of the second parameter. This is an illegal operation in maths
        //If we don't validate input or catch the error the application will crash
        static int Divide(int first, int second)
        {
            int result = 0;
            try
            {
                result = first / second;
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("Can't divide by zero");
            }
            return result; 
        }
    }
}
