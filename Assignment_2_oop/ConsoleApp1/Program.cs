using System;
using System.Xml.Linq;
using ConsoleApp1.part02;
using ConsoleApp1.part03;
using static ConsoleApp1.part03.Employee;


namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1 its same as demo 

            #endregion

            #region Q2 part02
            /*1*/
            //person[] person01 = new person[3];

            //person01[0] = new person("ahmed", 25);
            //person01[1] = new person("mona", 30);
            //person01[2] = new person("ali", 35);

            //for (int i = 0; i < person01.Length; i++)
            //{
            //    Console.WriteLine($"Person {i + 1}: Name = {person01[i].Name}, Age = {person01[i].Age}");
            //}

            /*2*/
            //    person[] person01 = new person[3];


            //    for (int i = 0; i < person01.Length; i++)
            //    {
            //        Console.WriteLine($"Enter details for person {i + 1}:");

            //        Console.Write("Name: ");
            //        string name = Console.ReadLine();

            //        int age = -1;

            //        do
            //        {
            //            Console.Write("Age: ");
            //            if (int.TryParse(Console.ReadLine(), out age) && age >= 0)
            //            {

            //                break;
            //            }
            //            else
            //            {
            //                Console.WriteLine("Invalid age. Please enter valid number ");
            //            }
            //        } while (true);




            //        person01[i] = new person(name, age);
            //    }


            //    Console.WriteLine("\nDetails of all persons:");
            //    foreach (var person in person01)
            //    {
            //        Console.WriteLine($"Name = {person.Name}, Age = {person.Age}");
            //    }


            //    person oldest = person01[0];
            //    foreach (var person in person01)
            //    {
            //        if (person.Age > oldest.Age)
            //        {
            //            oldest = person;
            //        }
            //    }

            //    Console.WriteLine($"\nThe oldest person is {oldest.Name}, Age = {oldest.Age}");






            #endregion

            #region َQ3 part 03 
            #region with property  

            //Employee[] EmpArr = new Employee[3];

            //EmpArr[0] = new Employee(1, "Alice", "F", SecurityLevel.DBA, 80000, new HiringDate(15, 5, 2015));
            //EmpArr[1] = new Employee(2, "Bob", "M", SecurityLevel.Guest, 50000, new HiringDate(10, 7, 2018));
            //EmpArr[2] = new Employee(3, "Charlie", "M", SecurityLevel.Secretary, 45000, new HiringDate(20, 3, 2017));


            //Console.WriteLine("Original Employee List:");
            //foreach (var emp in EmpArr)
            //{
            //    Console.WriteLine(emp);
            //}


            //var sortedEmpArr = EmpArr.OrderBy(emp => new DateTime(emp.HireDate.Year, emp.HireDate.Month, emp.HireDate.Day)).ToArray();


            //Console.WriteLine("\nSorted Employee List (by Hire Date):");
            //foreach (var emp in sortedEmpArr)
            //{
            //    Console.WriteLine(emp);
            //}


            //int boxingCount = 0, unboxingCount = 0;


            //foreach (var emp in EmpArr)
            //{
            //    object boxed = emp;
            //    boxingCount++;

            //    Employee unboxed = (Employee)boxed;
            //    unboxingCount++;
            //}


            //Console.WriteLine($"\nBoxing occurred {boxingCount} times.");
            //Console.WriteLine($"Unboxing occurred {unboxingCount} times.");
            #endregion

            #region with getter and setter 
            Employee[] EmpArr = new Employee[3];

            EmpArr[0] = new Employee(1, "mona", "F", SecurityLevel.DBA, 80000, new HiringDate(15, 5, 2015));
            EmpArr[1] = new Employee(2, "ali", "M", SecurityLevel.Guest, 50000, new HiringDate(10, 7, 2018));
            EmpArr[2] = new Employee(3, "ahmed", "M", SecurityLevel.Secretary, 45000, new HiringDate(20, 3, 2017));

            
            Console.WriteLine("Original Employee List:");
            foreach (var emp in EmpArr)
            {
                Console.WriteLine(emp);
            }

            
            var sortedEmpArr = EmpArr.OrderBy(emp => new DateTime(emp.GetHireDate().GetYear(), emp.GetHireDate().GetMonth(), emp.GetHireDate().GetDay())).ToArray();

            
            Console.WriteLine("\nSorted Employee List (by Hire Date):");
            foreach (var emp in sortedEmpArr)
            {
                Console.WriteLine(emp);
            }

           
            int boxingCount = 0, unboxingCount = 0;

           
            foreach (var emp in EmpArr)
            {
                object boxed = emp;  
                boxingCount++;

                Employee unboxed = (Employee)boxed;  
                unboxingCount++;
            }

           
            Console.WriteLine($"\nBoxing occurred {boxingCount} times.");
            Console.WriteLine($"Unboxing occurred {unboxingCount} times.");
        }
        #endregion
        #endregion




    }
}


