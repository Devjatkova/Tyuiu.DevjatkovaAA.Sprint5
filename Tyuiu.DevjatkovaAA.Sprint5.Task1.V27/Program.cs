using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.DevjatkovaAA.Sprint5.Task1.V27.Lib;

namespace Tyuiu.DevjatkovaAA.Sprint5.Task1.V27
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнила: Девяткова А. А. | АСОиУБ-23-3";
            //Длина строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись набора данных в текстовый файл                 *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #27                                                             *");
            Console.WriteLine("* Выполнила: Девяткова Анастасия Александровна | АСОиУБ-23-3              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана функция F(x) = (3x - 1,5)/(sin(x) - 3+x) + 2 (произвести           *");
            Console.WriteLine("* табулирование) f(x) на заданном диапазоне [-5,5] с шагом 1. Произвести  *");
            Console.WriteLine("* проверку деления на 0. Результат сохранить в текстовый файл             *");
            Console.WriteLine("* OutPutFileTask1.txt и вывести на консоль в таблицу. Значеия округлить   *");
            Console.WriteLine("* до двух знаков после запятой.                                           *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine("startValue = " + startValue);
            Console.WriteLine("stopValue = " + stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string res = ds.SaveToFileTextData(startValue, stopValue);

            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");
            Console.ReadKey();
        }
    }
}
