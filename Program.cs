using System;
using System.Collections.Generic;

namespace Day01LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part01

            //First Qusetion

            var age = 22;
            var name = "Muhammed Ahmed";
            var GPA = 2.2;
            var isGraduated = false;
            var numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine(age.GetType());
            Console.WriteLine(name.GetType());
            Console.WriteLine(GPA.GetType());
            Console.WriteLine(isGraduated.GetType());
            Console.WriteLine(numbers.GetType());

            //Second Qusetion

            int age2 = 22;
            String name2 = "Muhammed Ahmed";
            double GPA2 = 2.2;
            bool isGraduated2 = false;

            Console.WriteLine(age2);
            Console.WriteLine(name2);
            Console.WriteLine(GPA2);
            Console.WriteLine(isGraduated2);

            // Both versions are the same at compile time because the compiler
            // infers the type of each var variable from its assigned value.

            #endregion

            #region Part02

            //Third Qusetion

            var Product = new
            {
                Name = "Laptop",
                Price = 1000.00,
                Quantity = 5
            };
            Console.WriteLine(Product.Name);
            Console.WriteLine(Product.Price);
            Console.WriteLine(Product.Quantity);

            //Fourth Qusetion

            var Student = new[]
            {
                new { Name = "Muhammed Ahmed", Grade = "C" },
                new { Name = "Emad", Grade = "B" },
                new { Name = "Boda", Grade = "B" }
            };

            foreach (var student in Student)
            {
                Console.WriteLine($"Name: {student.Name}, Grade: {student.Grade}");
            }

            #endregion

            #region Part03

            //Fifth Qusetion

            Console.WriteLine("level".IsPalindrome());
            Console.WriteLine("madam".IsPalindrome());
            Console.WriteLine("hello".IsPalindrome());
            Console.WriteLine("radar".IsPalindrome());

            //Sixth Qusetion
            Console.WriteLine(7.IsPrime());
            Console.WriteLine(10.IsPrime());
            Console.WriteLine(13.IsPrime());
            Console.WriteLine(20.IsPrime());

            #endregion

            #region Part04

            //Seventh Qusetion

            List<string> employees = new List<string>();

            employees.Add("Ahmed");
            employees.Add("Mohamed");
            employees.Add("Ali");
            employees.Add("Omar");

            employees.Remove("Ali");

            string searchName = "Mohamed";
            bool found = false;

            foreach (string employee in employees)
            {
                if (employee == searchName)
                {
                    found = true;
                    break;
                }
            }

            if (found)
            {
                Console.WriteLine($"{searchName} was found.");
            }
            else
            {
                Console.WriteLine($"{searchName} was not found.");
            }

            Console.WriteLine("\nFinal List:");

            foreach (string employee in employees)
            {
                Console.WriteLine(employee);
            }

            //Eighth Qusetion

            List<Employee> employees1 = new List<Employee>();

            employees1.Add(new Employee("Ahmed", 5000));
            employees1.Add(new Employee("Mohamed", 8000));
            employees1.Add(new Employee("Ali", 4500));
            employees1.Add(new Employee("Omar", 10000));

            decimal salaryLimit = 6000;

            foreach (Employee employee1  in employees1)
            {
                if (employee1.Salary > salaryLimit)
                {
                    Console.WriteLine($"Name: {employee1.Name}, Salary: {employee1.Salary}");
                }
            }

            #endregion

            #region LastPart
            /*
             1. What is the difference between a delegate and a lambda expression?
                    A delegate is a type that can reference a method,
                while a lambda expression is a short way to write an anonymous function that can be assigned to a delegate.

            2. Why is var still statically typed even though the type isn't written explicitly?
                var is statically typed because the compiler determines the variable's type at compile time from the assigned value.
            Once the type is determined, it cannot change to another type.

            3. Give one real scenario where an anonymous type is more convenient than creating a full class.
                An anonymous type is useful when we need a temporary object with a few properties, 
            such as storing a student's Name and Grade for display. In this case, creating a full class would be unnecessary. 
             */
            #endregion
        }

    }
    static class Extensions
    {
        public static bool IsPalindrome(this string str)
        {
            for (int i = 0; i < str.Length / 2; i++)
            {
                if (str[i] != str[str.Length - 1 - i])
                    return false;
            }

            return true;
        }

        public static bool IsPrime(this int number)
        {
            if (number <= 1)
                return false;

            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }
    }
    class  Employee
    {
        public string Name { get; set; }
        public decimal Salary { get; set; }

        public Employee(string name, decimal salary)
        {
            Name = name;
            Salary = salary;
        }
    }
}
