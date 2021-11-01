using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите максимальную температуру за сутки");
            double maxtemperature = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите минимальную температуру за сутки");
            double mintemperature = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Средняя температура равна " + ((maxtemperature + mintemperature) / 2));

            Console.ReadKey();
        }
    }
}
