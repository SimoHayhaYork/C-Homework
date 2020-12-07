/*
            3.
            а)  Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). 
            Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);
            б) *Выполните предыдущее задание, оформив вычисления расстояния между точками в виде метода;
                            Никандров Андрей
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_work_1._3
{
    class Program
    {
        static double Distance(double x1, double y1, double x2, double y2)          //Метод вычисления расстояния
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }

        static void Main(string[] args)
        {
            double x1 = 4.2;
            double y1 = 5.1;
            double x2 = 7.9;
            double y2 = 14.7;

            Console.WriteLine("Эта программа поможет вам расчитать расстояние между точками." +
               Environment.NewLine + "Для точек с координатами ({0:0.#}; {1:0.#}) и ({2:0.#}; {3:0.#})" +
               Environment.NewLine + "расстояние равняется: ", x1, y1, x2, y2);

            double distance = Distance(x1, y1, x2, y2);

            Console.WriteLine("{0:F2}", distance);

            Console.ReadLine();
        }

    }
}