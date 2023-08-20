namespace DependencyInjection.Employee;

public interface IDataAccessLayer
{
	public List<Employee> GetAllEmployees();
}