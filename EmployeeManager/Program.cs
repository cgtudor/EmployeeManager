﻿using System;

namespace EmployeeManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the employee name");
            string name = Console.ReadLine();
            Console.WriteLine("Please enter the employee ID");
            string id = Console.ReadLine();
            Console.WriteLine("Please enter the hours worked");
            int hours = Int32.Parse(Console.ReadLine());
            double wage = hours <= 40 ? hours * 9.5 : 40 * 9.5 + (hours-40) * 14.25;
            Console.WriteLine("Employee Name: " + name);
            Console.WriteLine("Employee ID: " + id);
            Console.WriteLine("The weekly wage is " + string.Format("{0:0.00}", wage));
        }
    }
}
