using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    internal class DateTimeMeethod
    {

        public void ShowDateTimeMethod()
        {
            DateTime d;
            d= DateTime.Now;
            Console.WriteLine(d);
            Console.WriteLine($"day --> {d.Day}");
            Console.WriteLine($"month --> {d.Month}");
            Console.WriteLine($"year --> {d.Year}");


            Console.WriteLine($"Hour -->{d.Hour}");
            Console.WriteLine($"min-->{d.Minute}");
            Console.WriteLine($"second -->{d.Second}");
            Console.WriteLine($"millisec-->{d.Millisecond}");


            Console.WriteLine($"shorttime--> {d.ToShortDateString()}");
            Console.WriteLine($"longtime--> {d.ToLongTimeString()}");
            Console.WriteLine($"shortdate--> {d.ToShortDateString()}");
            Console.WriteLine($"longdate--> {d.ToLongDateString()}");

            Console.WriteLine($"day of the week: {d.DayOfWeek.ToString()}");
            Console.WriteLine($"day of the  year: {d.DayOfYear}");


        }
    }
}
