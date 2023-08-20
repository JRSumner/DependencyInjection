﻿// A sandbox to practice the implementation of DI.

using DependencyInjection.Employee;

Console.WriteLine("Dependency Inject Sandbox");

var businessLayer = new EmployeeBL();
var dataAccessLayer = new EmployeeDAL(); //Original implementation of the data access layer.
var dataAccessLayerTest = new EmployeeDAL_Test(); //A Test implementation of the data access layer.
var employeeList = businessLayer.ListAllEmployees(dataAccessLayerTest);

foreach (var employee in employeeList)
{
	Console.WriteLine($"Id: {employee.Id} \nFirst Name:{employee.FirstName} \nLast Name: {employee.LastName} \nDepartment: {employee.Department} \n");
}

Console.ReadLine();