/*
        1.
        Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку.
        а) используя склеивание;
        б) используя форматированный вывод;
        в) *используя вывод со знаком $.
                            Никандров Андрей
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_work_1._1
{
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Назовите ваше имя: ");
        string a = Console.ReadLine();
        Console.WriteLine("Назовите вашу фамилию: ");
        string b = Console.ReadLine();
        Console.WriteLine("Назовите свой возраст: ");
        string c = Console.ReadLine();
        Console.WriteLine("Назовите свой рост: ");
        string d = Console.ReadLine();
        Console.WriteLine("Назовите свой вес: ");
        string f = Console.ReadLine();
        Console.WriteLine("Ваше имя: " + a + ", ваша фамилия: " + b + ", ваш возраст: " + c + ", ваш рост: " + d + ", ваш вес: " + f);               //Вывод через склеивание
        Console.WriteLine("Ваше имя: {0}, ваша фамилия: {1}, ваш возраст: {2}, ваш рост: {3}, ваш вес: {4}", a, b, c, d, f);             //Вывод через форматированный вывод
        Console.WriteLine($"Ваше имя: {a}, ваша фамилия: {b}, ваш возраст: {c}, ваш рост: {d}, ваш вес: {f}");           //Вывод через доллар(*)
        Console.ReadLine();

    }
}
}
