/*
        Create the following OOP class hierarchy:
    
    •	Person – general class for anyone, holding id, first name and last name.
    
    o	Employee – general class for all employees, holding the field salary and department.
        The department can only be one of the following: Production, Accounting, Sales or Marketing.
    	Manager – holds a set of employees under his command.
    
    	RegularEmployee
    
    -	SalesEmployee – holds a set of sales. A sale holds product name, date and price.
    -	Developer – holds a set of projects. A project holds project name, project start date, details and a state (open or closed). 
        A project can be closed through the method CloseProject().
    
    o	Customer – holds the net purchase amount (total amount of money the customer has spent).
        Extract interfaces for each class. (e.g. IPerson, IEmployee, IManager, etc.)
        The interfaces should hold their public properties and methods (e.g. IPerson should hold id, first name and last name).
        Each class should implement its respective interface.
        Define proper constructors. Avoid code duplication through abstraction. Encapsulate all data and validate the input.
        Throw exceptions where necessary. Override ToString() in all classes to print detailed information about the object.
        Create several employees of type Manager, SalesEmployee and Developer and add them in a single collection.
        Finally, print them in a for-each loop.
*/

namespace Problem_3.Company_Hierarchy
{
    using System;
    using System.Collections.Generic;
    using Company.Employees;
    using Company.Employees.Resources;
    using Company.Customers;

    class CompanyHierarchy
    {
        static void Main(string[] args)
        {
            // PESHO DEVELOPER PROJECTS LIST
            IList<Project> peshoProjects = new List<Project>()
            {
                new Project("PeshoWebSite", new DateTime(), "Pesho's web page", "closed")
            };

            // EMPLOYEE LIST
            IList<Employee> employeesList = new List<Employee>();

            // GOSHO SALES LIST
            IList<Sale> goshoSaleList = new List<Sale>()
            {
                new Sale("Hosting", 500, new DateTime(2014, 1, 12)),
                new Sale("Web domain", 200, new DateTime(2014, 2, 11)),
                new Sale("VPS Server", 600, new DateTime(2015, 3, 13))
            };

            // PESHO DEVELOPER
            Developer peshoDeveloper = new Developer("Pesho", "Georgiev", 1, 1500M, "Production", peshoProjects);
            SalesEmployee goshoSalesEmployee = new SalesEmployee("Gosho", "Ivanov", 5, 2000, "Sales", goshoSaleList);

            // ADD PESHO TO EMPLOYEES LIST
            employeesList.Add(peshoDeveloper);

            // PESHO's MANAGER
            Manager peshoDeveloperManager = new Manager("Big", "Boss", 2, 5000M, "Production", employeesList);

            // PRINT PESHO AND PESHO's MANAGER
            Console.WriteLine(peshoDeveloperManager + "\r\n");
            Console.WriteLine(peshoDeveloper + "\r\n");

            // PRINT GOSHO AND GOSHO SAILS LIST
            Console.WriteLine(goshoSalesEmployee);
            Console.WriteLine("\r\nSales:\r\n{0}\r\n", String.Join("", goshoSaleList));

            // LIST OF EMPLOYEES OVERALL
            IList<Employee> companyEmployees = new List<Employee>();
            companyEmployees.Add(goshoSalesEmployee);
            companyEmployees.Add(peshoDeveloper);
            companyEmployees.Add(peshoDeveloperManager);

            // PRINT EACH COMPANY EMPLOYEE
            Console.WriteLine("Company employees overall:");
            foreach (var employee in companyEmployees)
            {
                Console.WriteLine(employee.FirstName + " " + employee.LastName);
            }

            // CUSTOMERS
            Customer tonchoCustumer = new Customer("Toncho", "Toshev", 6, 2424.22M);
            Customer petarCustomer = new Customer("Petar", "Petrov", 7, 4312.02M);
            Console.WriteLine("\r\nCustomers:\r\n");
            Console.WriteLine("{0}\r\n\r\n{1}", tonchoCustumer, petarCustomer);
        }
    }
}
