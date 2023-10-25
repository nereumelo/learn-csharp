using System;
using System.Collections.Generic;
using System.Linq;
using LearningPlatform.ContentContext;
using LearningPlatform.SubscriptionContext;

namespace LearningPlatform
{
    class Program
    {
        static void Main(string[] args)
        {
            // var course = new Course("Fundamentos de OOP", "fundamentos-oop", EContentLevel.Beginner);
            // course.Modules.Add(new Module("Primeiros Passos", "primeiros-passos"));
            // course.Modules[0].Lectures.Add(new Lecture("Paradigma Orientado a Objetos", "paradigma-orientado-a-objetos"));
            // var career = new Career("Desenvolvedor .NET", "desenvolvedor-dotnet");
            // career.Items.Add(new CareerItem(2, course.Name, "Aprenda os Fundamentos de OOP2", course));
            // career.Items.Add(new CareerItem(3, course.Name, "Aprenda os Fundamentos de OOP3", null));
            // career.Items.Add(new CareerItem(1, course.Name, "Aprenda os Fundamentos de OOP1", null));

            // Console.WriteLine($"[{career.GetType().Name}] {career.Name} - {career.Url}");
            // if (career.Items.Count > 0)
            // {
            //     Console.WriteLine("Items:");
            //     foreach (var item in career.Items.OrderBy(x => x.Order))
            //     {
            //         Console.WriteLine($"  [{item.GetType().Name} #{item.Order}] {item.Name} - {item.Description}");
            //         if (item.IsInvalid)
            //         {
            //             Console.WriteLine("  Notifications:");
            //             foreach (var notification in item.Notifications)
            //             {
            //                 Console.WriteLine($"    [{notification.GetType().Name}] {notification.Property} - {notification.Message}");
            //             }
            //         }
            //     }
            //     Console.WriteLine();
            // }

            var paypalSubscription = new PayPalSubscription();
            var student = new Student();
            student.CreateSubscription(paypalSubscription);
        }
    }
}
