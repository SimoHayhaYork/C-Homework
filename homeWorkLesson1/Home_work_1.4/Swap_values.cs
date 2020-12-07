/*
        4.
        Написать программу обмена значениями двух переменных.
        а) с использованием третьей переменной;
        б) *без использования третьей переменной.
                    Никандров Андрей
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_work_1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите два числа. Программа поменяет их местами");
            double a, b;
            a = Convert.ToDouble(Console.ReadLine());   //Ввод первого чила
            b = Convert.ToDouble(Console.ReadLine());   //Ввод второго числа
            b = a + b; 
            a = b - a; 
            b = b - a;      
            Console.WriteLine($"Первое число теперь равно: { a}, второе число равно: { b}");
            Console.ReadKey();

        }
    }
}