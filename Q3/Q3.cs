using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    internal class Q3
    {
        static void Main(string[] args)
        {
            double U_1_2, U_3, U_4_5, FG;
            Random rnd = new Random();

            U_3 = rnd.Next(0, 101);
            U_1_2 = rnd.Next(0, 101);
            U_4_5 = rnd.Next(0, 101);

            U_3 = U_3 * 0.17;
            U_1_2 = U_1_2 * 0.33;
            U_4_5 = U_4_5 * 0.50;

            Console.WriteLine("Dina's grades are");
            Console.WriteLine($"Unit 1 and 2: {U_1_2}");
            Console.WriteLine($"Unit 3: {U_3}");
            Console.WriteLine($"Unit 4 and 5: {U_4_5}");

            FG = U_3 + U_1_2 + U_4_5;

            Console.WriteLine($"Dina's Computer Science grade is: {FG}");
        }
    }
}
