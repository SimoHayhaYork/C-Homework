/*
                        а) Дописать класс для работы с одномерным массивом. Реализовать конструктор, создающий массив заданной размерности и 
                        заполняющий массив числами от начального значения с заданным шагом. Создать свойство Sum, которые возвращают сумму элементов массива, 
                        метод Inverse, меняющий знаки у всех элементов массива, метод Multi, умножающий каждый элемент массива на определенное число, свойство MaxCount,
                        возвращающее количество максимальных элементов. В Main продемонстрировать работу класса.
                        б) Добавить конструктор и методы, которые загружают данные из файла и записывают данные в файл.
                                        Никандров Андрей
 */

using System;
using System.IO;

namespace ArrayClass
{
    class Program
    {
        /// <summary>Метод считывает строку и проверяет на корректный целочисленный ввод</summary>
        /// <returns></returns>
        static int GetInt()
        {
            while (true)
                if (!int.TryParse(Console.ReadLine(), out int x))
                    Console.Write("Неверный ввод (требуется число).\nПожалуйста, повторите ввод: ");
                else return x;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует программа 'Демонстрация возможностей класса для работы с массивом'");
            Console.Write("Введите желаемый размер массива: ");
            int size = GetInt();
            Console.Write("Введите первый элемент массива: ");
            int firstElement = GetInt();
            Console.Write("Введите шаг для добавления последующих элементов: ");
            int step = GetInt();

            MyArray a = new MyArray(size, firstElement, step);

            Console.WriteLine("\nСоздан массив: [ " + a.ToString() + " ]\n");

            Console.WriteLine("Сумма элементов массива: " + a.Sum);

            a.Inverse = -1;

            Console.WriteLine("Массив с изменёнными знаками: [ " + a.ToString() + " ]\n");

            Console.Write("Введите число, на которое будут умножены элементы массива: ");

            a.Multi = GetInt();

            Console.WriteLine("Массив, умноженный на число: [ " + a.ToString() + " ]\n");

            Console.WriteLine("Максимальный элемент массива: " + a.Max);

            Console.WriteLine("Количество максимальных элементов массива: " + a.MaxCount);

            Console.WriteLine("=============================================================");

            Console.ReadKey();
        }
    }
}