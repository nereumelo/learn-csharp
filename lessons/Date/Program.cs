using System;
using System.Globalization;

namespace Date
{
    class Program
    {
        static void Main(string[] args)
        {
            // DateTimeExample();
            // FormattingDateTimeExample();
            // ChangingDateTimeExample();
            // ComparingDateTimeExample();
            // CultureInfoExample();
            // HandlingTimeZoneExample();
            // HandlingTimeSpanExample();
            // CheckIfIsWeekendExample();
            // GetDaysInMonthExample();
        }

        static void DateTimeExample()
        {
            // var date = new DateTime(); // datetime struct
            var date = new DateTime(2020, 10, 12, 8, 23, 14); // specified datetime struct
            // var date = DateTime.Now; // data atual
            Console.WriteLine(date);
            Console.WriteLine(date.Month);
            Console.WriteLine(date.Hour);
        }

        static void FormattingDateTimeExample()
        {
            // var date = new DateTime(2021, 10, 25, 8, 23, 14);
            var date = DateTime.Now;

            // y - year | M - month | D - day | h - hour | m - minute | s - second
            Console.WriteLine(date); // full year
            Console.WriteLine(string.Format("{0:yyyy}", date)); // full year
            Console.WriteLine(string.Format("{0:yy}", date)); // 2-digits year
            Console.WriteLine(string.Format("{0:y}", date)); // year with named month
            Console.WriteLine(string.Format("{0:M}", date)); // named month with day
            Console.WriteLine(string.Format("{0:MM}", date)); // numeric month
            Console.WriteLine(string.Format("{0:mm}", date)); // minute
            Console.WriteLine(string.Format("{0:D}", date)); // weekday with named date
            Console.WriteLine(string.Format("{0:yyyy/MM/dd}", date)); // custom format date
            Console.WriteLine(string.Format("{0:yyyy/MM/dd hh:mm:ss.ffffff}", date)); // custom format date and time
            Console.WriteLine(string.Format("{0:yyyy/MM/dd hh:mm:ss.fff zzz}", date)); // custom format date and time with timezone offset
            Console.WriteLine(string.Format("{0:d}", date)); // predefined format: short date
            Console.WriteLine(string.Format("{0:D}", date)); // predefined format: long date
            Console.WriteLine(string.Format("{0:t}", date)); // predefined format: short time
            Console.WriteLine(string.Format("{0:T}", date)); // predefined format: long time
            Console.WriteLine(string.Format("{0:g}", date)); // predefined format: short datetime
            Console.WriteLine(string.Format("{0:f}", date)); // predefined format: long datetime
            Console.WriteLine(string.Format("{0:r}", date)); // predefined format: RFC1123 datetime standard
            Console.WriteLine(string.Format("{0:s}", date)); // predefined format: sortable datetime standard
            Console.WriteLine(string.Format("{0:u}", date)); // predefined format: universal datetime standard
        }

        static void ChangingDateTimeExample()
        {
            var date = DateTime.Now;
            Console.WriteLine(date);

            Console.WriteLine(date.AddDays(-5));
            Console.WriteLine(date.AddMonths(1));
            Console.WriteLine(date.AddYears(-3));
        }

        static void ComparingDateTimeExample()
        {
            var date = DateTime.Now;

            if (date.Date == DateTime.Now.Date) // specify a range to compare (comparing date, MM/DD/YYYY, in this case)
            {
                Console.WriteLine("Is equal");
            }
        }

        static void CultureInfoExample()
        {
            var ptBR = new CultureInfo("pt-BR");
            var enUS = new CultureInfo("en-US");
            var deDE = new CultureInfo("de-DE");
            var date = DateTime.Now;

            Console.WriteLine(date.ToString("D", ptBR));
            Console.WriteLine(date.ToString("D", enUS));
            Console.WriteLine(date.ToString("D", deDE));
            Console.WriteLine(date.ToString("d", ptBR));
            Console.WriteLine(date.ToString("d", enUS));
            Console.WriteLine(date.ToString("d", CultureInfo.CurrentCulture)); // get the current culture of local environment
        }

        static void HandlingTimeZoneExample()
        {
            var date = DateTime.UtcNow;

            Console.WriteLine(date);
            Console.WriteLine(date.ToLocalTime());

            var customTimezone = TimeZoneInfo.FindSystemTimeZoneById("Pacific/Auckland"); // get the offset from timezone ID

            Console.WriteLine(customTimezone);
            Console.WriteLine(TimeZoneInfo.ConvertTimeFromUtc(date, customTimezone)); // convert an UTC datetime to specified timezone (handle daylight saving)
            Console.WriteLine(customTimezone.IsDaylightSavingTime(date)); // check if specified timezone presents daylight saving to specified datetime
        }

        static void HandlingTimeSpanExample()
        {
            // TimeSpan is used to operating DateTimes
            var timeSpan = new TimeSpan();
            Console.WriteLine(timeSpan);

            Console.WriteLine(new TimeSpan(7, 0, 0, 0));
            Console.WriteLine(new TimeSpan(3, 12, 43));
            Console.WriteLine(new TimeSpan(7, 0, 0, 0).Add(new TimeSpan(3, 12, 43)));
            Console.WriteLine(new TimeSpan(7, 0, 0, 0).Subtract(new TimeSpan(3, 12, 43)));
            Console.WriteLine(new TimeSpan(7, 0, 0, 0).Multiply(3));
            Console.WriteLine(new TimeSpan(7, 0, 0, 0).Divide(3));
            Console.WriteLine(new TimeSpan(7, 0, 0, 0).Divide(3).Days);
        }

        static void CheckIfIsWeekendExample()
        {
            var date = DateTime.Now;
            var isWeekend = date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday;

            Console.WriteLine(isWeekend);
        }

        static void GetDaysInMonthExample()
        {
            var daysInMonth = DateTime.DaysInMonth(2023, 10);

            Console.WriteLine(daysInMonth);
        }
    }
}
