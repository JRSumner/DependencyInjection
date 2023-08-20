namespace DependencyInjection.Employee
{
	public class KeyGenerator
	{
		private static Random _random = new();

		public static string GenerateKey()
		{
			return _random.Next(2) == 0 ? "Development" : "Test";
		}

		public static void Main()
		{
			Console.WriteLine(GenerateKey());
		}
	}
}
