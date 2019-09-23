using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManager
{
    public class Employee
    {
        public string name, id;
        public int hours;
        public double hourlyRate;
        public double wage;

        internal Employee()
        {
            GetHours();
            GetID();
            GetName();
            this.hourlyRate = 9.5;
            CalcWage();
        }
        internal Employee(string name, string id, int hours)
        {
            this.name = name;
            this.id = id;
            this.hours = hours;
            this.hourlyRate = 9.5;
            CalcWage();
        }

        override
        public string ToString()
        {
            return name + " " + "(" + id + ")";
        }

        private bool IsValidName(string name)
        {
            return (name.Length < 1 || name.Length > 50);
        }
        private string GetName()
        {
            Console.WriteLine("Please enter the employee name");
            name = Console.ReadLine();
            return !IsValidName(name) ? name : GetName();
        }
        private bool IsIdValid(string id)
        {
            char[] ids = id.ToCharArray();
            return id.Length != 3 || !Char.IsLetter(ids[0]) || !Char.IsDigit(ids[1]) || !Char.IsDigit(ids[2]);
        }
        private string GetID()
        {
            Console.WriteLine("Please enter the employee ID");
            id = Console.ReadLine();
            return !IsIdValid(id) ? id : GetID();
        }
        private int GetHours()
        {
            Console.WriteLine("Please enter the hours worked");
            hours = Int32.Parse(Console.ReadLine());
            return (hours < 1 || hours > 100) ? GetHours() : hours;
        }
        public void CalcWage()
        {
            wage = hours <= 40 ? hours * hourlyRate : 40 * 9.5 + (hours - 40) * 14.25;
        }
    }

}
