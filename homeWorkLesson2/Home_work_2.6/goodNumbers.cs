/*
                    6.       
                    Написать программу подсчета количества «Хороших» чисел в диапазоне от 1 до 1 000 000 000. 
                    Хорошим называется число, которое делится на сумму своих цифр. 
                    * Реализовать подсчет времени выполнения программы, используя структуру DateTime.
                                    Никандров Андрей
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_work_2_6
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

        static bool CheckGoodNumber(int value)
        {
            string s = Convert.ToString(value);
            int sum = 0;
            for (int i = 0; i < s.Length; i++)
            {
                sum += s[i] - '0';
            }
            if (value % sum == 0)
                return true;
            else
                return false;
        }

        static void Main(string[] args)
        {
            int AmountOfGoodNumbers = 0;
            Console.WriteLine("Вас приветствует программа 'подсчет количества «Хороших» чисел'");
            Console.Write("Задайте диапазон: от 1 до ");

            int end = GetInt();
            DateTime start = DateTime.Now;

            for (int i = 1; i < end; i++)
            {
                if (CheckGoodNumber(i))
                {
                    AmountOfGoodNumbers++;
                }
            }

            Console.Write("\nВремя работы программы: ");
            Console.WriteLine(DateTime.Now - start);

            Console.WriteLine("\nВ заданном диапазоне содержится " + AmountOfGoodNumbers + " «Хороших» чисел");

            Console.ReadLine();
        }
    }
}