using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Linq;


namespace Problem07_WorkingDays
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture =
                CultureInfo.InvariantCulture;
            string[] WorkingDays = { "Monday", "Tuesday", "Wednesday", "Thuesday", "Friday" };
            DateTime today = DateTime.Now;
            Console.WriteLine(today);
            DateTime endDate = DateTime.Parse(Console.ReadLine());
            int counter = 1;
            for (DateTime i = today; i <=endDate;i= i.AddDays(1))
            {
                if (WorkingDays.Contains(Convert.ToString(i.DayOfWeek)))
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
