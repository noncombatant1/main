using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("КАССОВЫЙ ЧЕК");
            int azs = 035;
            int kassa = 0004;
            int oper = 0354;
            double inn = 77000000;
            double pricelitr = 40;
            int totallitr = 70;
            double total = pricelitr * totallitr;

            Console.WriteLine($"АЗС {azs} КАССА {kassa} ОПЕРАТОР {oper}");
            Console.WriteLine($"ИНН ПРОДАВЦА {inn}");
            Console.WriteLine($"RBL  {pricelitr} X {totallitr}");
            Console.WriteLine($"ИТОГО {total}");
            Console.ReadKey();
        }
    }
}
