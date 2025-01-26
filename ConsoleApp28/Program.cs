using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28
{
    /// <summary>
    ///  Вывести на экран прямоугольник вида □, обрамленный символами (например, 16 на 16) и пустой внутри.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j;

            for (i = 0; i < 8; i++)

            {

                for (j = 1; j < 1 + i; j++)

                Console.Write(" ");

                Console.WriteLine("#");

            }

            Console.ReadKey();
        }
    }
}
