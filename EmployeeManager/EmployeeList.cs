using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManager
{
    class EmployeeList
    {
        List<Employee> employeeList;
        public EmployeeList()
        {
            employeeList = new List<Employee>();
        }

        public void AddEmployee(Employee employee)
        {
            employeeList.Add(employee);
        }

        public void ListEmployees()
        {
            int i = 1;
            foreach(var employee in employeeList)
            {
                Console.WriteLine(i + ". " + employee.ToString());
                i++;
            }
        }

        public void RemoveEmployee(int pos)
        {
            employeeList.RemoveAt(pos);
        }
    }
}
