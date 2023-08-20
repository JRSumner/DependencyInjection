namespace DependencyInjection.Employee
{
	public class EmployeeBL
	{
		private IDataAccessLayer _dataAccessLayer;

		public EmployeeBL(IDataAccessLayer dataAccessLayer)
		{
			_dataAccessLayer = dataAccessLayer;
		}

		public List<Employee> ListAllEmployees()
		{
			var employees = _dataAccessLayer.GetAllEmployees();

			return employees;
		}
	}
}
