using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, and Welcome to FizzBuzz by Devon Kubacki!");
            Console.WriteLine("Pressing enter will show the next number in the sequence.");
            Console.WriteLine("Enjoy!\n");
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                    Console.Write("Fizz");
                if (i % 5 == 0)
                    Console.Write("Buzz");
                if (!(i % 3 == 0 || i % 5 == 0))
                    Console.Write(i);

                Console.Write(Environment.NewLine);
                Console.WriteLine("Press enter to Continue...");
                Console.ReadLine();
            }
        }
    }
}
