//// Program.cs in EmployeeProject
//using System;
//using Repository_Domain;
//using Repository_Pattern;

//namespace EmployeeProject_1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            bool isRun = true;
//            while (isRun)
//            {
//                Console.Clear();
//                Console.WriteLine();
//                Console.WriteLine("================= Select Your Process =================");
//                Console.WriteLine("Press 1: To Get Employee Information");
//                Console.WriteLine("Press 2: To Add New Employee Information");
//                Console.WriteLine("Press 3: To Exit The Application");

//                string inputKey = Console.ReadLine();
//                Console.Clear();

//                if (inputKey == "1")
//                {
//                    var source = RepositoryFactory.Create<IEmployeeRepository>(ContextTypes.XMLSource);
//                    var items = source.GetAll();

//                    Console.WriteLine();
//                    Console.WriteLine("============= Employee Information ===========");
//                    foreach (var item in items)
//                    {
//                        Console.WriteLine($"{item.FullName}, {item.Position}, {item.Department}, {item.PhoneNumber}");
//                    }

//                    Console.Write("Press any key to continue...");
//                    Console.ReadKey();
//                }
//                else if (inputKey == "2")
//                {
//                    Employee employee = new Employee();

//                    Console.Write("Full Name: ");
//                    employee.FullName = Console.ReadLine();

//                    Console.Write("Position: ");
//                    employee.Position = Console.ReadLine();

//                    Console.Write("Department: ");
//                    employee.Department = Console.ReadLine();

//                    Console.Write("Phone Number: ");
//                    employee.PhoneNumber = Console.ReadLine();

//                    Console.Clear();

//                    IEmployeeRepository source = RepositoryFactory.Create<IEmployeeRepository>(ContextTypes.XMLSource);
//                    try
//                    {
//                        source.Insert(employee);
//                    }
//                    catch (Exception ex)
//                    {
//                        Console.Write(ex);
//                        Console.ReadKey();
//                        continue;
//                    }
//                }
//                else if (inputKey == "3")
//                {
//                    isRun = false;
//                }
//            }
//        }
//    }
//}

using System;
using Repository_Domain;
using Repository_Pattern;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeProject_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isRun = true;
            while (isRun)
            {
                Console.Clear();
                Console.WriteLine("================= Employee Management System =================");
                Console.WriteLine("Press 1: To Get Employee Information");
                Console.WriteLine("Press 2: To Add New Employee Information");
                Console.WriteLine("Press 3: To Update Employee Information");
                Console.WriteLine("Press 4: To Delete Employee Information");
                Console.WriteLine("Press 5: To Exit The Application");
                string inputKey = Console.ReadLine();
                Console.Clear();

                IEmployeeRepository employeeRepository = RepositoryFactory.Create<IEmployeeRepository>(ContextTypes.XMLSource);

                switch (inputKey)
                {
                    case "1":
                        ViewEmployees(employeeRepository);
                        break;
                    case "2":
                        AddEmployee(employeeRepository);
                        break;
                    case "3":
                        UpdateEmployee(employeeRepository);
                        break;
                    case "4":
                        DeleteEmployee(employeeRepository);
                        break;
                    case "5":
                        isRun = false;
                        break;
                    default:
                        Console.WriteLine("Invalid input. Please try again.");
                        break;
                }
            }
        }

        static void ViewEmployees(IEmployeeRepository employeeRepository)
        {
            var employees = employeeRepository.GetAll();

            Console.WriteLine("================= Employee Information ===========");
            foreach (var employee in employees)
            {
                Console.WriteLine($"{employee.FullName}, {employee.Position}, {employee.Department}, {employee.PhoneNumber}");
            }

            Console.Write("Press any key to continue...");
            Console.ReadKey();
        }

        static void AddEmployee(IEmployeeRepository employeeRepository)
        {
            Employee newEmployee = new Employee();

            Console.Write("Full Name: ");
            newEmployee.FullName = Console.ReadLine();

            Console.Write("Position: ");
            newEmployee.Position = Console.ReadLine();

            Console.Write("Department: ");
            newEmployee.Department = Console.ReadLine();

            Console.Write("Phone Number: ");
            newEmployee.PhoneNumber = Console.ReadLine();

            try
            {
                employeeRepository.Insert(newEmployee);
                Console.WriteLine("Employee added successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            Console.Write("Press any key to continue...");
            Console.ReadKey();
        }

        static void UpdateEmployee(IEmployeeRepository employeeRepository)
        {
            Console.Write("Enter the ID of the employee to update: ");
            if (int.TryParse(Console.ReadLine(), out int employeeId))
            {
                var existingEmployee = employeeRepository.Get(employeeId);

                if (existingEmployee != null)
                {
                    Console.Write("Enter new Full Name: ");
                    existingEmployee.FullName = Console.ReadLine();

                    Console.Write("Enter new Position: ");
                    existingEmployee.Position = Console.ReadLine();

                    Console.Write("Enter new Department: ");
                    existingEmployee.Department = Console.ReadLine();

                    Console.Write("Enter new Phone Number: ");
                    existingEmployee.PhoneNumber = Console.ReadLine();

                    try
                    {
                        employeeRepository.Update(existingEmployee);
                        Console.WriteLine("Employee updated successfully!");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error: {ex.Message}");
                    }
                }
                else
                {
                    Console.WriteLine($"Employee with ID {employeeId} not found.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input for employee ID.");
            }

            Console.Write("Press any key to continue...");
            Console.ReadKey();
        }

        static void DeleteEmployee(IEmployeeRepository employeeRepository)
        {
            Console.Write("Enter the ID of the employee to delete: ");
            if (int.TryParse(Console.ReadLine(), out int employeeId))
            {
                try
                {
                    if (employeeRepository.Delete(employeeId))
                    {
                        Console.WriteLine("Employee deleted successfully!");
                    }
                    else
                    {
                        Console.WriteLine($"Employee with ID {employeeId} not found.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine("Invalid input for employee ID.");
            }

            Console.Write("Press any key to continue...");
            Console.ReadKey();
        }
    }
}

