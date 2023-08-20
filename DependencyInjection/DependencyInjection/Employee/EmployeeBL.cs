namespace DependencyInjection.Employee
{
	public class EmployeeBL
	{
		public List<Employee> ListAllEmployees(IDataAccessLayer dataAccess)
		{
			var employees = dataAccess.GetAllEmployees();

			return employees;
		}
	}
}
