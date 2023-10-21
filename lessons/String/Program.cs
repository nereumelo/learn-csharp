using System;
using System.Text;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            // GuidExample();
            // StringInterpolationExample();
            // StringComparisonExample();
            // StringHandlingExample();
            StringBuilderExample();
        }

        static void GuidExample()
        {
            var id = Guid.NewGuid();
            // id.ToString();
            // id = new Guid("96a7699e-c8f8-48de-ae44-eaee245885af");

            Console.WriteLine(id);
        }

        static void StringInterpolationExample()
        {
            var price = 10.2;
            // var texto = "O preço do produto é " + price + " na promoção.";
            // var texto = string.Format("O preço do produto é {0} na promoção.", price);
            // var texto = $"O preço do produto é {price} na promoção";

            // with line wrapping (and special chars)
            var texto = $@"O preço do produto
            é {price}
            na promoção.";

            Console.WriteLine(texto);
        }

        static void StringComparisonExample()
        {
            var text = "Test";
            Console.WriteLine("\nCompareTo");
            Console.WriteLine(text.CompareTo("Test")); // Returns 0
            Console.WriteLine(text.CompareTo("test")); //Returns 1

            Console.WriteLine("\nContains");
            Console.WriteLine(text.Contains("Test")); // Returns true
            Console.WriteLine(text.Contains("test")); // Returns false
            Console.WriteLine(text.Contains("test", StringComparison.OrdinalIgnoreCase)); // Returns true because ignore case sensitive



            var text2 = "This text is a test";
            Console.WriteLine("\nEquals");
            Console.WriteLine(text2.Equals("This text is a test"));
            Console.WriteLine(text2.Equals("this text is a test"));
            Console.WriteLine(text2.Equals("this text is a test", StringComparison.OrdinalIgnoreCase));

            Console.WriteLine("\nStartWith");
            Console.WriteLine(text2.StartsWith("This")); // Returns true
            Console.WriteLine(text2.StartsWith("this")); // Returns false
            Console.WriteLine(text2.StartsWith("this", StringComparison.OrdinalIgnoreCase)); // Returns true

            Console.WriteLine("\nEndsWith");
            Console.WriteLine(text2.EndsWith("test")); // Returns true
            Console.WriteLine(text2.EndsWith("Test")); // Returns false
            Console.WriteLine(text2.EndsWith("Test", StringComparison.OrdinalIgnoreCase)); // Returns true
        }

        static void StringHandlingExample()
        {
            var text = "This text is a test";

            Console.WriteLine(text.ToLower()); // converts all the characters in a string to lowercase
            Console.WriteLine(text.ToUpper()); // converts all the characters in a string to uppercase
            Console.WriteLine(text.Insert(5, "here ")); // inserts a specified string at a specified position within the original stirng
            Console.WriteLine(text.Remove(5, 5)); // removes a specified number of characters from a string starting at a specified position
            Console.WriteLine(text.Length); // returns the number of characters of the string
            Console.WriteLine(text.Replace("text", "sentence")); // replaces all occurrences of a specified substring within a string

            var words = text.Split(" "); // splits a string into an array of substrings based on a specified delimiter
            Console.WriteLine($"{words[0]} | {words[1]} | {words[2]} | {words[3]} | {words[4]}");

            Console.WriteLine(text.Substring(5, 4)); // extracts a portion of a string

            Console.WriteLine($"  {text}  ".Trim()); // removes leading and trailing whitespaces from a string
        }

        static void StringBuilderExample()
        {
            var text = new StringBuilder();
            text.Append("Thiss is a test"); // appends content to the end of the StringBuilder
            text.Insert(6, "tezt "); // inserts content at a specified position within the StringBuilder
            text.Replace("tezt", "text"); // replaces all occurrences of a specified substring within the StringBuilder
            text.Remove(4, 1); // removes a specified number of characters from the StringBuilder starting at a specified position

            Console.WriteLine(text.ToString()); // ! should always as possible use ToString method to handle a StringBuilder as a string
        }
    }
}
