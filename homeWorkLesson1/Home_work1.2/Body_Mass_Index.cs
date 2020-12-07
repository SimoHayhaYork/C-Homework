/*
        2.
        Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); 
        где m — масса тела в килограммах, h — рост в метрах. 
                    Никандров Андрей 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_work_1._2
{
    class Program
    {
      
        static void Main(string[] args)
        {
            Console.WriteLine("Здравствуйте. Эта программа поможет вам расчитать индекс массы тела. \nВведите массу тела в килограммах.");
            double weight, height;
            weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Хорошо. \nТеперь введите рост в метрах.");
            height = Convert.ToDouble(Console.ReadLine());
            height /= 100;
            double i =(weight / (height * height));
            Console.WriteLine( "Индекс массы тела:\n" + i);      
            Console.ReadLine();

        }
    }
}
