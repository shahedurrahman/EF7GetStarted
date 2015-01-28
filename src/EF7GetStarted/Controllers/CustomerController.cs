using EF7GetStarted.Models;
using Microsoft.AspNet.Mvc;
using System.Collections.Generic;

namespace EF7GetStarted.Controllers
{
	[Route("api/[controller]")]
	public class CustomerController : Controller
	{
        [HttpGet]
        public IActionResult Get()
        {
            var customers = new List<Customer>
            {
                new Customer
                {
                    Id = 101,
                    Name="Customer 101"
                },
                new Customer
                {
                    Id = 102,
                    Name="Customer 102"
                },
                new Customer
                {
                    Id = 103,
                    Name="Customer 103"
                },
                new Customer
                {
                    Id = 104,
                    Name="Customer 104"
                }
            };

            return new ObjectResult(customers);
        }
    }
}