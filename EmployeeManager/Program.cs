using System;
using System.Text.RegularExpressions;

namespace EmployeeManager
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeList empList = new EmployeeList();
            int choice = 0;
            while(choice != 4)
            {
                Console.WriteLine("1. Add Employee");
                Console.WriteLine("2. List Employees");
                Console.WriteLine("3. Remove Employee");
                Console.WriteLine("4. Quit");
                choice = Int32.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        var employee = new Employee();
                        empList.AddEmployee(employee);
                        break;
                    case 2:
                        empList.ListEmployees();
                        break;
                    case 3:
                        Console.WriteLine("Please input position of employee to be deleted");
                        int position = Int32.Parse(Console.ReadLine());
                        empList.RemoveEmployee(position);
                        break;
                    case 4:
                        return;
                }
            }
        }
    }
}
