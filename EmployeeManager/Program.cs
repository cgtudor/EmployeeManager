using System;
using System.Text.RegularExpressions;

namespace EmployeeManager
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = GetName();
            string id = GetID();
            int hours = GetHours();
            double wage = CalcWage(hours);
            Console.WriteLine("Employee Name: " + name);
            Console.WriteLine("Employee ID: " + id);
            Console.WriteLine("The weekly wage is " + string.Format("{0:0.00}", wage));
        }

        static private bool IsValidName(string name)
        {
            return (name.Length < 1 || name.Length > 50);
        }
        static private string GetName()
        {
            Console.WriteLine("Please enter the employee name");
            string name = Console.ReadLine();
            return !IsValidName(name) ? name : GetName();
        }
        static private bool IsIdValid(string id)
        {
            char[] ids = id.ToCharArray();
            return id.Length != 3 || !Char.IsLetter(ids[0]) || !Char.IsDigit(ids[1]) || !Char.IsDigit(ids[2]);
        }
        static private string GetID()
        {
            Console.WriteLine("Please enter the employee ID");
            string id = Console.ReadLine();
            return !IsIdValid(id) ? id : GetID();
        }
        static private int GetHours()
        {
            Console.WriteLine("Please enter the hours worked");
            int hours = Int32.Parse(Console.ReadLine());
            return (hours < 1 || hours > 100) ? GetHours() : hours;
        }
        static private double CalcWage(int hours)
        {
            return hours <= 40 ? hours * 9.5 : 40 * 9.5 + (hours - 40) * 14.25;
        }
    }
}
