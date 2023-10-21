using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            // ArrayExample();
            // IteratingArrayExample();
            StructArrayExample();
        }

        static void ArrayExample()
        {
            int[] arr = new int[5] { 72, 73, 74, 75, 76 }; // arr: [72,73,74,75,76]
            // var arr = new int[5]; // arr: [0,0,0,0,0]

            Console.WriteLine(arr[0]);
            Console.WriteLine(arr[1]);
            Console.WriteLine(arr[2]);
            Console.WriteLine(arr[3]);
            Console.WriteLine(arr[4]);
            Console.WriteLine(arr.Length);
        }

        static void IteratingArrayExample()
        {
            var arr = new int[5] { 33, 34, 35, 36, 37 };

            for (var index = 0; index < arr.Length; index++)
                Console.WriteLine(arr[index]);

            foreach (var item in arr)
                Console.WriteLine(item);
        }

        static void StructArrayExample()
        {
            var employees = new Employee[3];
            employees[0] = new Employee() { Id = 3421, Name = "Bob" };
            employees[1] = new Employee() { Id = 7592, Name = "Lisa" };

            foreach (var employee in employees)
            {
                Console.WriteLine(employee.Id + " - " + employee.Name);
            }
        }
    }

    public struct Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
