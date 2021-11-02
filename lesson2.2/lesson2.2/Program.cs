using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер текущего месяца");
            int numberofmounth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите среднюю температуру текущего месяца");
            double midleTemperature = Convert.ToDouble(Console.ReadLine());
            string mouthTitle = "";

            if (midleTemperature > 0 && (numberofmounth == 1 || numberofmounth == 2 || numberofmounth == 12))
            {
                Console.WriteLine("Дождливая зима");
            }
            else
            {
                switch (numberofmounth)
                {
                    case 1:
                        mouthTitle = "Январь";
                        break;
                    case 2:
                        mouthTitle = "Февраль";
                        break;
                    case 3:
                        mouthTitle = "Март";
                        break;
                    case 4:
                        mouthTitle = "Апрель";
                        break;
                    case 5:
                        mouthTitle = "Май";
                        break;
                    case 6:
                        mouthTitle = "Июнь";
                        break;
                    case 7:
                        mouthTitle = "Июль";
                        break;
                    case 8:
                        mouthTitle = "Август";
                        break;
                    case 9:
                        mouthTitle = "Сентябрь";
                        break;
                    case 10:
                        mouthTitle = "Октябрь";
                        break;
                    case 11:
                        mouthTitle = "Ноябрь";
                        break;
                    case 12:
                        mouthTitle = "Декабрь";
                        break;
                }
                Console.WriteLine("Текущий месяц - " + mouthTitle);
            }
            Console.Read();
        }
    }
}
