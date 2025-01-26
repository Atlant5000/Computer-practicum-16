using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    /// <summary>
    /// Вывести на экран 4 горизонтальные строки, каждая из которых состоит из 7 символов, отделенных друг от друга пустыми строками.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("а) ");
             int i, j, a;

            for (i = 0; i < 4; i++)

            {
                a = 1;
                for (j = 0; j < 10; j++)

                {
                     Console.Write($"{a}\t");
                    a++;
                }
                Console.WriteLine();
            }
            a = 41;
            Console.WriteLine("б) ");
            for (i = 0; i < 4; i++)

            {
                for (j = 0; j < 10; j++)
                {
                    Console.Write($"{a}\t");
                    a++;
                }
                Console.WriteLine();
            }
            Console.WriteLine("в) ");
            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < i; j++)
                {
                    Console.Write("5\t");
                }
                for (j = 0; j < 1; j++)
                {
                    Console.Write("5\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("г) ");
            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < i; j++)
                {
                    Console.Write("1\t");
                }
                for (j = 0; j < 1; j++)
                {
                    Console.Write("1\t");
                }
                Console.WriteLine();
            }
        }
    }
 }

