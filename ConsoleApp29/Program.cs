using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29
{
    /// <summary>
    ///  Вывести на экран прямоугольник вида □, обрамленный символами (например, 16 на 16) и пустой внутри.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 16;
            int b = 16;

            for (int i = 0; i < b; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    if (i == 0 || i == b - 1 || j == 0 || j == a - 1)
                    {
                        Console.Write("#");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                    Console.WriteLine();
            }
        }
    }
}

