/*
            7.
            a) Разработать рекурсивный метод, который выводит на экран числа от a до b (a<b);
            б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.
                        Никандров Андрей
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_work_2_7
{
    class Program
    {
        static int GetInt() //Нужно убедиться, что введено цифровое значение
        {
            while (true)
                if (!int.TryParse(Console.ReadLine(), out int x))
                    Console.Write("Неверный ввод (Введите число).\nПожалуйста повторите ввод: ");
                else return x;
        }

        static void PrintFromTo(int start, int end)
        {
            if (start == end)
            {
                Console.Write("\b\b");
                Console.Write(" ");
                return;
            }
            else
            {
                Console.Write(start + ", ");
                start++;
                PrintFromTo(start, end);
            }
        }

        static long SumFromTo(int start, int end, long result)
        {
            if (start == end) return result;
            else
            {
                result += start;
                start++;
                return SumFromTo(start, end, result);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует программа 'рекурсивный подсчет чисел от A до B'");

            Console.Write("Введите число A: ");
            int a = GetInt();

            Console.Write("Введите число B: ");
            int b = GetInt();

            Console.Write("\nЦелые числа между двумя введёнными: ");
            PrintFromTo(a, b);

            Console.WriteLine("\nСумма всех чисел между введёнными: " + SumFromTo(a, b, 0));

            Console.ReadLine();
        }
    }
}