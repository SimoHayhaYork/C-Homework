/*
            5.
            а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, 
            нужно ли человеку похудеть, набрать вес или все в норме;
            б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
                                Никандров Андрей
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_work_2_5
{
    class Program
    {

        static string CheckNorm(double index, double height)
        {
            string result = "";
            if (index >= 18.5 && index <= 24.99)
            {
                result = "Всё в норме";
            }
            else if (index < 18.5)
            {
                double recommendation = (18.5 - index) * height * height;
                result = String.Format("Необходимо набрать {0:0.00} кг для нормализации веса.", recommendation);
            }
            else if (index > 24.99)
            {
                double recommendation = (index - 24.99) * height * height;
                result = String.Format("Необходимо сбросить {0:0.00} кг для нормализации веса.", recommendation);
            }

            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Здравствуйте. Эта программа поможет вам расчитать индекс массы тела. \nВведите массу тела в килограммах.");
            double weight, height;
            weight = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Хорошо. \nТеперь введите рост в метрах.");
            height = Convert.ToDouble(Console.ReadLine());
            height /= 100;
            double index = (weight / (height * height));
            
            Console.WriteLine("Индекс массы тела:\n" + index);
            Console.WriteLine(CheckNorm(index, height));
            
            Console.ReadLine();
        }
    }
}