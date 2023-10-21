using System;
using System.Globalization;

namespace Numeric
{
    class Program
    {
        static void Main(string[] args)
        {
            // FormattingNumericExample();
            // CultureInfoExample();
            RoundingNumericExample();
        }

        static void FormattingNumericExample()
        {
            decimal value = 10.256m;

            Console.WriteLine(value);
            Console.WriteLine(value.ToString("G")); // general format with default number of significant digits: all
            Console.WriteLine(value.ToString("G3")); // general format with 3 significant digits
            Console.WriteLine(value.ToString("N")); // number format with default number of decimal places: depends on culture
            Console.WriteLine(value.ToString("N3")); // number format with 3 decimal places
            Console.WriteLine(value.ToString("F")); // fixed-point format with default number of decimal places: depends on culture
            Console.WriteLine(value.ToString("F3")); // fixed-point format with 3 decimal places
            Console.WriteLine(value.ToString("P")); // percent format with default number of decimal places: depends on culture
            Console.WriteLine(value.ToString("P0")); // percent format with 0 decimal places
            Console.WriteLine(value.ToString("C")); // currency format with default number of decimal places: depends on culture
            Console.WriteLine(value.ToString("C3")); // currency format with 3 decimal places
            Console.WriteLine(value.ToString("E")); // exponencial format with default number of decimal places: 6
            Console.WriteLine(value.ToString("E2")); // exponencial format with 2 decimal places
        }

        static void CultureInfoExample()
        {
            decimal value = 10.256m;

            // Can use new CultureInfo or CultureInfo.CreateSpecificCulture to specify a culture
            Console.WriteLine(value.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR")));
            Console.WriteLine(value.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
            Console.WriteLine(value.ToString("C", CultureInfo.CreateSpecificCulture("de-DE")));
            Console.WriteLine(value.ToString("C", CultureInfo.CreateSpecificCulture("ja-JP")));
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine(value.ToString("C3", CultureInfo.CreateSpecificCulture("pt-BR")));
            Console.WriteLine(value.ToString("C3", CultureInfo.CreateSpecificCulture("en-US")));
            Console.WriteLine(value.ToString("C3", CultureInfo.CreateSpecificCulture("de-DE")));
            Console.WriteLine(value.ToString("C3", CultureInfo.CreateSpecificCulture("ja-JP")));
        }

        static void RoundingNumericExample()
        {
            decimal value = 10536.25m;

            Console.WriteLine(value);
            Console.WriteLine(Math.Round(value)); // round to nearest integral value
            Console.WriteLine(Math.Ceiling(value)); // round to upper integral value
            Console.WriteLine(Math.Floor(value)); // round to lower integral value
        }
    }
}
