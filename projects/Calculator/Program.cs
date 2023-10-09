using System;
using System.Runtime.Intrinsics;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"{(short)EOperation.Sum} - {EOperation.Sum}");
                Console.WriteLine($"{(short)EOperation.Difference} - {EOperation.Difference}");
                Console.WriteLine($"{(short)EOperation.Product} - {EOperation.Product}");
                Console.WriteLine($"{(short)EOperation.Division} - {EOperation.Division}");
                Console.WriteLine("0 - Exit");
                Console.Write("\nEnter an option: ");
                short option = short.Parse(Console.ReadLine());
                float result;

                switch (option)
                {
                    case 1: result = Sum(); break;
                    case 2: result = Difference(); break;
                    case 3: result = Product(); break;
                    case 4: result = Division(); break;
                    case 0: return;
                    default: continue;
                }

                Console.WriteLine($"Result: {result}");
                Console.Write("\nPress any key to continue...");
                Console.ReadKey();
            };
        }

        static float getValue(string ask)
        {
            Console.Write(ask);
            return float.Parse(Console.ReadLine());
        }

        static float Sum()
        {
            float v1 = getValue("Enter the first value: ");
            float v2 = getValue("Enter the second value: ");

            return v1 + v2;
        }

        static float Difference()
        {
            float v1 = getValue("Enter the first value: ");
            float v2 = getValue("Enter the second value: ");

            return v1 - v2;
        }

        static float Product()
        {
            float v1 = getValue("Enter the first value: ");
            float v2 = getValue("Enter the second value: ");

            return v1 * v2;
        }

        static float Division()
        {
            float v1 = getValue("Enter the first value: ");
            float v2 = getValue("Enter the second value: ");

            return v1 / v2;
        }

        static void ShowResult(float? result)
        {
            if (result != null)
                Console.WriteLine($"Result: {result}");
        }
    }

    enum EOperation
    {
        Sum = 1,
        Difference = 2,
        Product = 3,
        Division = 4,
    }
}
