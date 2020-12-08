/*
        2.
        Написать метод подсчета количества цифр числа.
                    Никандров Андрей

 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_work_2_2
{
    class Program
    {

        static int AmountOfCharInNumber(string number)
        {
            return number.Length;
        }

        static string GetNumericString() //Нужно убедиться, что введено цифровое значение
        {
            string number = "";
            bool checkNotAnumber;
            do
            {
                checkNotAnumber = false;
                number = Console.ReadLine();
                for (int i = 0; i < number.Length; i++)
                {
                    if (!Char.IsNumber(number, i))
                    {
                        checkNotAnumber = true;
                        Console.Write("Неверный ввод (Введите число).\nПожалуйста, повторите ввод: ");
                        break;
                    }
                }
            } while (checkNotAnumber);
            return number;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует программа 'Подсчёт количества цифр в числе'");
            Console.Write("Введите число: ");

            string number = GetNumericString();

            Console.WriteLine(Environment.NewLine + "Количество цифр: " + AmountOfCharInNumber(number));

            Console.ReadLine();
        }
    }
}