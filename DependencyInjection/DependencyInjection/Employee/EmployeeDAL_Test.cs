namespace DependencyInjection.Employee
{
	public class EmployeeDAL_Test : IDataAccessLayer
	{
		public List<Employee> GetAllEmployees()
		{
			var employees = new List<Employee>
			{
				new Employee
				{
					Id = 1,
					FirstName = "TEST_John",
					LastName = "TEST_Smith",
					Department = "TEST_Finance"
				},
				new Employee
				{
					Id = 2,
					FirstName = "TEST_Jane",
					LastName = "TEST_Doe",
					Department = "TEST_Marketing"
				},
				new Employee
				{
					Id = 3,
					FirstName = "TEST_Joe",
					LastName = "TEST_Blogs",
					Department = "TEST_IT"
				}
			};

			return employees;
		}
	}
}
