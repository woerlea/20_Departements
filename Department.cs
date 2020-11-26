using System;
using System.Collections.Generic;
using System.Text;

namespace _20_Departments
{
    class Department
    {
        public string Name { get; set; }
        public Person Worker { get; set; }
        List<Person> employeeList = new List<Person>();
        List<Department> Departments = new List<Department>();

        public void AddDepartment(Department newDepartment)
        {
            this.Departments.Add(newDepartment);
        }

        public Department(string name)
        {
            this.Name = name;
        }

        public void AddEmployee(Person worker)
        {
            this.employeeList.Add(worker);
        }

        // Mitarbeitername wird gedruckt
        public void GetEmployee()
        {
            foreach (Person worker in employeeList)
            {
                Console.WriteLine(worker.Name);
            }
        }

        // Abteilung und MA-Name werden gedruckt
        public string GetDepartmentEmployees()
        {
            string result = "";
            foreach (Person worker in this.employeeList)
            {
                result += "\n" + worker.ToString();
            }
            return result;
        }

    }
}
