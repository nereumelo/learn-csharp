using System;
using System.IO;
using System.Threading;

namespace TextEditor
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
                Console.WriteLine("O - Open file");
                Console.WriteLine("C - Create new file");
                Console.WriteLine("Q - Quit");
                Console.Write("\nEnter an option: ");

                char option = char.Parse(Console.ReadLine().ToUpper());

                switch (option)
                {
                    case 'O': Open(); break;
                    case 'C': Create(); break;
                    case 'Q': return;
                    default: continue;
                }
            }
        }

        static void Open()
        {
            Console.Clear();
            Console.Write("Enter the file path: ");
            string path = Console.ReadLine();

            using var file = new StreamReader(path);
            string text = file.ReadToEnd();

            Console.WriteLine(text);
            AwaitPressKey();
        }

        static void Create()
        {
            Console.Clear();
            Console.WriteLine("(Press ESC to escape)");
            Console.WriteLine("Enter the text here:");
            string text = "";

            do
            {
                text += Console.ReadLine();
                text += Environment.NewLine;
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);

            Save(text);
        }

        static void Save(string text)
        {
            Console.Clear();
            Console.WriteLine("Where to save the file?");
            var path = Console.ReadLine();

            using var file = new StreamWriter(path);
            file.Write(text);

            Console.WriteLine($"File successful saved at {path}");
            AwaitPressKey();
        }

        static void AwaitPressKey()
        {
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }
    }
}
