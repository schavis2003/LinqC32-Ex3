using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        public static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        public static int X { get; private set; }

        static void Main(string[] args)
        {
            /*
             * 
             * Complete every task using Method OR Query syntax. 
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             * 
             */

            //TODO: Print the Sum of numbers

            Console.WriteLine($"The sum is  : {numbers.Sum()}");

            //TODO: Print the Average of numbers

            Console.WriteLine($"The average is  :{numbers.Average()}");

            //TODO: Order numbers in ascending order and print to the console

            Console.WriteLine("Give me the number in ascending order:  ");
            numbers.OrderBy(x => x).ToList().

                ForEach(x => Console.WriteLine(x));
                {

                }


            //TODO: Order numbers in decsending order and print to the console

            Console.WriteLine("Give me the number in descending order:  ");
            numbers.OrderByDescending(x => x).ToList().

                ForEach(x => Console.WriteLine(x));
                      
                {

                }


            //TODO: Print to the console only the numbers greater than 6
            Console.WriteLine("Tell me which numbers are greater than 5:  ");
            numbers.Where( x => x > 5).ToList().

                ForEach(x => Console.WriteLine(x));
                {

                }

            //TODO: Order numbers in any order (acsending or desc) but only print 4 of them **foreach loop only!**
            Console.WriteLine("Only print seven numbers in ascending order:  ");
            
                foreach (var item in numbers.OrderBy(x => x).Take(7))
                {

                Console.WriteLine(item);

                }

            //TODO: Change the value at index 4 to your age, then print the numbers in decsending order

            Console.WriteLine("-----");

            numbers[5] = 21;

            numbers.SetValue(21, 5);
            Console.WriteLine("I changed number at index 5: ");
            var descWithAge = numbers.OrderByDescending(num => num);

            foreach (var number in descWithAge)
            {
                Console.WriteLine();
            }

            
            // List of employees ****Do not remove this****
            var employees = CreateEmployees();

            //TODO: Print all the employees' FullName properties to the console
            //only if their FirstName starts with a C
            //OR an S
            //order this in ascending
            //order by FirstName.

            Console.WriteLine("Starts with C or S");
            employees.Where(x => x.FirstName.StartsWith("C") || x.FirstName.StartsWith("S")).OrderBy(x => x.FirstName).ToList().ForEach (x => Console.WriteLine(x.FullName));


            //var filtered = employees.Where(person => )


            //TODO: Print all the employees' FullName and Age who are over the age 26 to the console and order this by Age first and then by FirstName in the same result.

            Console.WriteLine("Employees over 26 years old:  ");
            employees.Where(employee => employee.Age > 26)
                .OrderBy(Employee => Employee.Age)
                .ThenBy(employee => employee.FirstName)
                .ToList()
                .ForEach(x => Console.WriteLine($"{x.FullName}  Age:{x.Age}"));
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();


            //TODO: Print the Sum and then the Average of the employees' YearsOfExperience
            //if their YOE is less than or equal to 10 AND Age is greater than 35.

            Console.WriteLine("Years of Experience less than or equl to 10 and age is greater than 35: ");
            //var sum = employees.Where(x => x.YearsOfExperience <= 10 && x.Age > 35).
               int sum = employees.Where(x => x.YearsOfExperience <= 10 && x.Age > 35).Sum(x => x.YearsOfExperience);

            Console.WriteLine("Same as before but the  Average instead of the sum:  ");
            double average = employees.Where(x => x.YearsOfExperience <= 10 && x.Age > 35).Average(x => x.YearsOfExperience);
            Console.WriteLine(Math.Round(average));
            Console.WriteLine(sum);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            //TODO: Add an employee to the end of the list without using employees.Add()
            Console.WriteLine("Added a new employee:  ");

            employees.Append(new Employee("Prince", "Nelson", 56, 11)).ToList().

                ForEach(x => Console.WriteLine(x.FullName));

            Console.WriteLine();

            Console.ReadLine();
        }

        #region CreateEmployeesMethod
        private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
            employees.Add(new Employee("Steven", "Bustamento", 56, 5));
            employees.Add(new Employee("Micheal", "Doyle", 36, 8));
            employees.Add(new Employee("Daniel", "Walsh", 72, 22));
            employees.Add(new Employee("Jill", "Valentine", 32, 43));
            employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
            employees.Add(new Employee("Big", "Boss", 23, 14));
            employees.Add(new Employee("Solid", "Snake", 18, 3));
            employees.Add(new Employee("Chris", "Redfield", 44, 7));
            employees.Add(new Employee("Faye", "Valentine", 32, 10));

            return employees;
        }
        #endregion
    }
}
