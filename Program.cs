using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISDWeek1
{
    class MyFactorial
    {
        public int MyFact(int f)
        {
            int res = 1;

            for (int i = 1; i < f + 1; i++)
                res = res * i;

            return res;
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            int fact, res;
            MyFactorial Ex = new MyFactorial();

            Console.Title = "Factorial";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("Write a number:");
            fact = Convert.ToInt32(Console.ReadLine());
            res = Ex.MyFact(fact);
            Console.WriteLine($"Factorial = {res}");

        }
    }
}
