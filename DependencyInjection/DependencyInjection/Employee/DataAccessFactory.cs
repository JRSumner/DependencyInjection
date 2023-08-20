namespace DependencyInjection.Employee
{
	public class DataAccessFactory
	{
		public IDataAccessLayer Create(string key)
		{
			switch (key)
			{
				case "Development":
					return new EmployeeDAL();
				case "Test":
					return new EmployeeDAL_Test();
				default:
					throw new ArgumentException();
			}
		}
	}
}
