/*
        1.  
        Написать метод, возвращающий минимальное из трех чисел.
                        Никандров Андрей
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_work_2_1
{
    class Program
    {

        static int minOfThree(int a, int b, int c)
        {
            if (a >= b)
            {
                if (b >= c)
                {
                    return c;
                }
                else
                {
                    return b;
                }

            }
            else
            {
                if (a >= c)
                {
                    return c;
                }
                else
                {
                    return a;
                }
            }
        }

        static int GetInt() //Нужно убедиться, что введено цифровое значение
        {
            while (true)
                if (!int.TryParse(Console.ReadLine(), out int x))
                    Console.Write("Неверный ввод (Введите число).\nПожалуйста, повторите ввод: ");
                else return x;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует программа 'Минимальное из трёх введённых чисел' ");
            Console.Write("Введите первое число: ");
            int a = GetInt();

            Console.Write("Введите второе число: ");
            int b = GetInt();

            Console.Write("Введите третье число: ");
            int c = GetInt();

            Console.WriteLine(Environment.NewLine + "Минимальным является: " + minOfThree(a, b, c));

            Console.ReadLine();
        }
    }
}