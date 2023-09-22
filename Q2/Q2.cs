using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    internal class Q2
    {
        static void Main(string[] args)
        {
            int x, Hundreds, Tens, Ones, Hundreds2, Tens2, Ones2, answer;

            Random rnd = new Random();

            x = rnd.Next(100, 1000);

            Console.WriteLine(x);

            Hundreds = x / 100 * 100;
            Tens = (x - Hundreds) / 10 * 10;
            Ones = x - Tens - Hundreds;

            Hundreds2 = x / 100; ;
            Ones2 = (x - Tens - Hundreds) * 100;

            answer = Hundreds2 + Tens + Ones2;

            Console.WriteLine($"Hundred = {Hundreds}");
            Console.WriteLine($"Ten = {Tens}");
            Console.WriteLine($"One = {Ones}");
            Console.WriteLine(answer);

        }
    }
}
