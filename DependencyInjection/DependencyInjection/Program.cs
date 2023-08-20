// A sandbox to practice the implementation of DI.

using DependencyInjection.Employee;

Console.WriteLine("Dependency Inject Sandbox");

var businessLayer = new EmployeeBL();
var employeeList = businessLayer.ListAllEmployees();

foreach (var employee in employeeList)
{
	Console.WriteLine($"Id: {employee.Id} \nFirst Name:{employee.FirstName} \nLast Name: {employee.LastName} \nDepartment: {employee.Department} \n");
}

Console.ReadLine();