/*
                3.
                С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
                                             Никандров Андрей
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_work_2_3
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

        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует программа 'Подсчет нечетных положительных чисел");
            Console.WriteLine("Вводите числа по одному, для завершения введите 42: ");

            int AmountOfOddNumbers = 0;
            while (true)
            {
                int number = GetInt();
                if (number == 42)
                {
                    break;
                }
                else if (number > 0 && number % 2 == 1)
                {
                    AmountOfOddNumbers++;
                }
            }

            Console.WriteLine(Environment.NewLine + "Количество нечётных положительных чисел: " + AmountOfOddNumbers);

            Console.ReadLine();
        }
    }
}
