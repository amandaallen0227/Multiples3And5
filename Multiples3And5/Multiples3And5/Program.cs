using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiples3And5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I don't liiike math at all");
            Console.ReadLine();

            int three = 0;
            for (int i = 3; i <= 1000; i += 3)
            {           
                three += i;
            }
            Console.WriteLine($"This is the sum of all the multiples of 3 under 1000: {three}");
            Console.ReadLine();
            int five = 0;
            for (int i = 5; i <= 1000; i+= 5)
            {
                five += i;
            }
            Console.WriteLine($"This is the sum of all the multiples of 5 under 1000: {five}");
            Console.ReadLine();
            Console.WriteLine($"This is the sum of all multiples of 3 AND 5 {three + five}");
            Console.ReadLine();
        }
    }
}
