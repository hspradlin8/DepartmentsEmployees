using System;
using DepartmentsEmployees2.Data;
using DepartmentsEmployees2.Models;

namespace DepartmentsEmployees2
{
    class Program
    {
        static void Main(string[] args)
        {
            var departmentRepo = new DepartmentRepository();
            var allDepartments = departmentRepo.GetAllDepartments();

            Console.WriteLine("All Departments");
            Console.WriteLine("------------------");
            foreach (var dept in allDepartments)
            {
                Console.WriteLine(dept.DepartmentName);
            }

            var hardCodedId = 3;

            var departmentWithId3 = departmentRepo.GetDepartmentById(hardCodedId);

            Console.WriteLine("-------");
            Console.WriteLine($"Department with id {hardCodedId} is {departmentWithId3.DepartmentName}");

            var employeeRepo = new EmployeeRepository();
            var allEmployees = employeeRepo.GetAllEmployees();

            Console.WriteLine("All Employees");
            Console.WriteLine("------------------");
            foreach (var emp in allEmployees)
            {
                Console.WriteLine(emp.FirstName);
                Console.WriteLine(emp.LastName);
            }

            var empHardCodedId = 3;

            var employeeWithId3 = employeeRepo.GetEmployeeById(empHardCodedId);

            Console.WriteLine("-------");
            Console.WriteLine($"{employeeWithId3.FirstName} {employeeWithId3.LastName}");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            var allEmployeesWithDept = employeeRepo.GetAllEmployeesWithDepartment();
            Console.WriteLine("Employees with departments");
            foreach (var emp in allEmployeesWithDept) 
            {
                Console.WriteLine(emp.FirstName);
                Console.WriteLine(emp.LastName);
                Console.WriteLine(emp.DepartmentId);
               // Console.WriteLine(emp.Department);
            }

            var legal = new Department();

            Console.WriteLine("What department would you like to add?");


            legal.DepartmentName = Console.ReadLine();
            
            departmentRepo.AddDepartment(legal);

            Console.WriteLine("What Department (ID) would you like to update?");
            var departmentToUpdate = Int32.Parse(Console.ReadLine());

            Console.WriteLine("What should the new department name be called?");
            var newDepartmentName = Console.ReadLine();

            departmentRepo.UpdateDepartment(departmentToUpdate, new Department { DepartmentName = newDepartmentName});

           
        }
    }
}
