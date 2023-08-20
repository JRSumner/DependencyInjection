namespace DependencyInjection.Employee
{
	public class EmployeeDAL : IDataAccessLayer
	{
		public List<Employee> GetAllEmployees()
		{
			var employees = new List<Employee>
			{
				new Employee
				{
					Id = 1,
					FirstName = "John",
					LastName = "Smith",
					Department = "Finance"
				},
				new Employee
				{
					Id = 2,
					FirstName = "Jane",
					LastName = "Doe",
					Department = "Marketing"
				},
				new Employee
				{
					Id = 3,
					FirstName = "Joe",
					LastName = "Blogs",
					Department = "IT"
				}
			};

			return employees;
		}
	}
}
