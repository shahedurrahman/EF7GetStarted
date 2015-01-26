using EF7GetStarted.Models;
using Microsoft.AspNet.Mvc;

namespace EF7GetStarted.Controllers
{
	[Route("api/[controller]")]
	public class CustomerController : Controller
	{
		[HttpGet]
		public IActionResult Get()
		{
			var customer = new Customer();

			return new ObjectResult(customer);
		}

		public void Test()
		{
			
		}
	}
}