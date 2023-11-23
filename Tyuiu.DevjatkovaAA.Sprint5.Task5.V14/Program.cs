using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.DevjatkovaAA.Sprint5.Task5.V14.Lib;
using System.IO;

namespace Tyuiu.DevjatkovaAA.Sprint5.Task5.V14
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
            Console.WriteLine("* Тема: Чтение данных из текстового файла                                 *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #14                                                             *");
            Console.WriteLine("* Выполнила: Девяткова Анастасия Александровна | АСОиУБ-23-3              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл С:/DataSprint5/InPutDataFileTask5V14.txt (файл взять из архива *");
            Console.WriteLine("* согласно вашему варианту.                                               *");
            Console.WriteLine("* Создать папку в ручную С:/DataSprint5/ и скопировать в неё файл) в      *");
            Console.WriteLine("* котором есть набор значений. Найти факториал наибольшего целого         *");
            Console.WriteLine("* числа, которое делится на 3, в файле. Полученный результат вывести на   *");
            Console.WriteLine("* консоль. У вещественных значений округлить до трёх знаков после         *");
            Console.WriteLine("* запятой.                                                                *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = $@"C:\DataSprint5\InPutDataFileTask5V14.txt";

            Console.WriteLine("Данные находятся в файле: " + path);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double res = ds.LoadFromDataFile(path);

            Console.WriteLine("Факториал = "+res);
            Console.ReadKey();
        }
    }
}
