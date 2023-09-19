using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Mango.Services.CouponAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class EmployeeController : ControllerBase
	{
		private readonly IEmployeeRepository employeeRepository;

		public EmployeeController(IEmployeeRepository employeeRepository)
		{
			this.employeeRepository = employeeRepository;
		}

		[HttpGet("")]
		public IActionResult GetPermanentEmployee()
		{
			return Ok(employeeRepository.GetMessage());
		}

		//[HttpGet("")]
		//public IActionResult GetPermanentEmployee([FromKeyedServices("permanentEmployee")] IEmployeeRepository employeeRepository)
		//{
		//	return Ok(employeeRepository.GetMessage());
		//}

		//[HttpGet("")]
		//public IActionResult GetPermanentEmployee([FromKeyedServices("permanentEmployee")] IEmployeeRepository employeeRepository)
		//{
		//	return Ok(employeeRepository.GetMessage());
		//}

		//[HttpGet("temp")]
		//public IActionResult GetContractualEmployee([FromKeyedServices("contractualEmployee")] IEmployeeRepository employeeRepository)
		//{
		//	return Ok(employeeRepository.GetMessage());
		//}
	}
}
