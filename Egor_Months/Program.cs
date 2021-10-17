using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Egor_Months.BaseElements;

namespace Egor_Months
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер месяца");

            int.TryParse(Console.ReadLine(), out int id);

            Month.GetById(id);

            Console.WriteLine("Введите кол-во дней в месяце");

            int.TryParse(Console.ReadLine(), out int days);

            Month.GetByDays(days);

            Console.ReadKey();
        }
    }
}
