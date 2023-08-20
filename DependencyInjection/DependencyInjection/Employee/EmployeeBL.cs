namespace DependencyInjection.Employee
{
	public class EmployeeBL
	{
		public List<Employee> ListAllEmployees()
		{
			var dataAccessLayer = new EmployeeDAL();
			var employees = dataAccessLayer.GetAllEmployees();

			return employees;
		}
	}
}
