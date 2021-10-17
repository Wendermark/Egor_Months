using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egor_Months.BaseElements
{
    enum Months
    {
        January = 1,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December
    }

    class Month
    {
        public static void GetById(int id)
        {
            if (id < 1 || id > 12)
            {
                Console.WriteLine("Такого месяца не существует!");
                return;
            }

            Console.WriteLine($"Месяц - { (Months)id } Кол-во дней - {DateTime.DaysInMonth(DateTime.Now.Year, id)}");
        }

        public static void GetByDays(int days)
        {
            if (days < 28 || days > 31 || days.Equals(29))
            {
                Console.WriteLine("Таких месяцев не существует!");
                return;
            }

            for (Months i = Months.January; i < Months.December; i++)
            {
                if (DateTime.DaysInMonth(DateTime.Now.Year, (int)i).Equals(days))
                    Console.WriteLine(i.ToString());
            }
            
        }
    }
}
