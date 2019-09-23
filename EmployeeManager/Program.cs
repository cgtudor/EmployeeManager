using System;
using System.Text.RegularExpressions;

namespace EmployeeManager
{
    class Program
    {
        static void Main(string[] args)
        {
            var employee = new Employee();
            Console.WriteLine("Employee Name: " + employee.name);
            Console.WriteLine("Employee ID: " + employee.id);
            Console.WriteLine("The weekly wage is " + string.Format("{0:0.00}", employee.wage));
        }
    }
}
