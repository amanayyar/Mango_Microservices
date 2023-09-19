namespace Mango.Services.CouponAPI
{
	public interface IEmployeeRepository
	{
		public string GetMessage();
	}
	public class PermanentEmployee : IEmployeeRepository
	{
		public string GetMessage()
		{
			return "This is an Permanent Employee";
		}
	}
	public class ContractualEmployee : IEmployeeRepository
	{
		public string GetMessage()
		{
			return "This is an Contractual Employee";
		}
	}
}
