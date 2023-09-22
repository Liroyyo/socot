using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace socot
{
    internal class Q1
    {
        static void Main(string[] args)
        {
            int x, y, z, l, a;

            Console.WriteLine("Enter the change amount");
            x = int.Parse(Console.ReadLine());

            if (x < 0)
            {
                Console.WriteLine("The amount can’t be negative");
            }

            else
            {

                y = x / 10;
                z = (x - y * 10) / 5;
                l = (x - y * 10 - z * 5) / 1;
                a = y + z + l;
                Console.WriteLine($"10 = {y} 5 = {z} 1 = {l} amount of coins = {a}");
            }

        }
    }
}
