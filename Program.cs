using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*      _____________
                    | 1 | 0 | 2 |
                    |-----------|
                    | 3 | 4 | 5 |
                    |___________|
             */      
            /*
             //1
            Console.Write("Высота - ");
            int a1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ширина - ");
            int b1 = Convert.ToInt32(Console.ReadLine());

            for (int a = a1; a<= b1; a++)
            {
                for (int b = 1; b<= a; b++)
                {
                    Console.Write($" {a}");
                }
                Console.WriteLine(" ");
            }*/


            /*
            //2
          Console.Write("Введите высоту пирамиды: ");
          int height = int.Parse(Console.ReadLine());

          Console.WriteLine("\nПирамида:");

          for (int i = 1; i <= height; i++)
          {
              for (int j = 1; j <= height - i; j++)
                  {
              Console.Write(" ");
                  }

              for (int k = 1; k <= 2 * i - 1; k++)
                  {
              Console.Write("#");
                  }

          Console.WriteLine();
          }
            */
            /*
             //3
            int height = int.Parse(Console.ReadLine());
            for (int i = 1; i <= height; i++)
            {
                for (int j = 1; j <= height - i; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 1; k <= 10; k++)
                {
                    Console.Write("#");
                }

                Console.WriteLine();
            }
            */
            /*
             /4
            Console.Write("Введите четное число - ");
            int height = int.Parse(Console.ReadLine());
            if (height % 2 != 0)
            {
                for (int uppir = 1; uppir <= height; uppir += 2)
                {
                    for (int space = 0; space < (height - uppir) / 2; space++)
                    {
                        Console.Write(" ");
                    }

                    for (int sumb = 1; sumb <= uppir; sumb++)
                    {
                        Console.Write("#");
                    }

                    Console.WriteLine();
                }
                for (int downpir = height - 2; downpir >= 1; downpir -= 2)
                {
                    for (int space = 0; space < (height - downpir) / 2; space++)
                    {
                        Console.Write(" ");
                    }

                    for (int sumb = 1; sumb <= downpir; sumb++)
                    {
                        Console.Write("#");
                    }
                    Console.WriteLine();
                }
            }
            */
            //5
            /*
            Console.WriteLine("Введите четное число");
            int height = int.Parse(Console.ReadLine());
            if (height % 2 != 0)
            {
                for (int downpir = height - 2; downpir >= 1; downpir -= 2)
                {
                    for (int space = 0; space < (height - downpir) / 2; space++)
                    {
                        Console.Write(" ");
                    }

                    for (int sumb = 1; sumb <= downpir / 2; sumb++)
                    {
                        Console.Write("#");
                    }
                    Console.WriteLine();
                }
            }
            */
            //1.	Число Армстронга – такое число из К цифр, для которого сумма К-х степеней его цифр равна самому числу. Например, 153=13+53+33. Найти все числа Армстронга из трех цифр.
            /*
            for(int i = 100; i <= 999; i++) 
            {
                int s = i / 100;
                int d = (i / 10) % 10;
                int e = i % 10;
                if (Math.Pow(s, 3) + Math.Pow(d, 3) + Math.Pow(e, 3) == i)
                {
                    Console.WriteLine($"Число Армстронга - {i}");
                }


            }
            */
            //2.	Четырехзначное число считается счастливым, если сумма его первых двух цифр равна сумме последних двух цифр. По другой версии, счастливым является число, в котором сумма двузначных чисел первой и второй половины равна 100. Найти все 4-значные числа, счастливые одновременно и в том, и в другом смысле. 


            /*
            for (int i = 1000; i <= 9999; i++)
            {
                int t = i / 1000;
                int s = (i / 100) % 10;
                int d = (i % 100) / 10;
                int e = i % 10;

                if (t + s == d + e & i / 100 + i % 100 == 100)
                {
                    Console.WriteLine(i);
                }
            }
            */
            //3.	У «счастливых» шестизначных билетов сумма первых трех цифр равна сумме последних трех цифр. Сколько их?
            /*
            int count = 0;
            for (int i = 100000; i <= 999999; i++)
            {



                if (i / 100000 + (i / 10000) % 10 + (i / 1000) % 10 == (i % 1000) / 100 + ((i % 100) / 10) % 10 + i % 10)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
            */

            //4.	Натуральное число называется совершенным, если оно равно сумме своих делителей, включая 1 и, естественно, исключая это самое число. Например, совершенным является число 6 ( 6 1 2 3 ). Найти все совершенные числа, меньшие 100 000.

            /*
             for(int number = 1; number <= 100000; number++)
             {
                 int xd = 0;
                 for (int del = 1; del < number; del++) 
                 {

                 if ( number % del == 0)
                     {
                         xd += del;
                     }
                 }

                 if (xd == number)
                 {
                     Console.WriteLine(number);

                 }

             }
            */
            //5.	В некоторой стране используются денежные купюры достоинством в 1, 2, 4, 8, 16, 32 и 64. Дано натуральное число n. Как наименьшим количеством таких денежных купюр можно выплатить суммы n, n 1, ..., n 10 (указать количество каждой из используемых для выплаты купюр)? Предполагается, что имеется достаточно большое количество купюр всех достоинств
            /*
            Console.WriteLine("Введите сумму");
            int pay = Convert.ToInt32(Console.ReadLine());
            for (int money = 64; money > 0; money/=2)
            {
                int count = 0;
                for (int i= 0; i <= pay; i++) {

                    if (pay - money >= 0)
                    {
                        count++;
                        pay = pay - money;
                    }
                }
                Console.WriteLine($"{money} -  {count}");
            }*/

            Console.ReadKey();
        }
    }
}
