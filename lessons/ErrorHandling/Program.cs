using System;

namespace ErrorHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            // HandlingExceptionExample();
            // ThrowingNewExceptionExample();
            // CreatingCustomExceptionExample();
            UsingFinallyExample();
        }

        static void HandlingExceptionExample()
        {
            var arr = new int[3];

            try
            {
                for (var index = 0; index < 10; index++)
                {
                    Console.WriteLine(arr[index]);
                }
            }
            catch (IndexOutOfRangeException ex) // Specifics exceptions should be before the generic exception
            {
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message);
                Console.WriteLine("Exception: Not found index in the list");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message);
                Console.WriteLine("Exception: Ops, something seems wrong");
            }
        }

        static void ThrowingNewExceptionExample()
        {
            string text = null;

            if (string.IsNullOrEmpty(text))
                throw new ArgumentNullException("text", "The text should not be null or empty.");
        }

        static void CreatingCustomExceptionExample()
        {
            try
            {
                throw new MyException();
            }
            catch (MyException ex)
            {
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.OccurredAt);
                Console.WriteLine("Exception: My exception");
            }
        }

        static void UsingFinallyExample()
        {
            try
            {
                throw new Exception("Any error message");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message);
                Console.WriteLine("Exception: Error found");
            }
            finally
            {
                Console.WriteLine("reached the end");
            }
        }
    }

    public class MyException : Exception
    {
        public MyException()
        {
            OccurredAt = DateTime.UtcNow;
        }
        public DateTime OccurredAt { get; set; }
    }
}
