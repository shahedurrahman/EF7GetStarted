using System.Collections.Generic;
using EF7GetStarted.Models;
using Microsoft.AspNet.Mvc;

namespace EF7GetStarted.Controllers
{
	[Route("api/[controller]")]
	public class PersonController : Controller
	{
		/*
		// GET: api/values
		[HttpGet]
		public IEnumerable<string> Get()
		{
			return new string[] { "value1", "value2", "value3" };
		}
		*/

		[HttpGet]
		public IActionResult Get()
		{
			var persons = new List<Person>
			{
				new Person
				{
					Id = 101,
					Name="Customer 101"
				},
				new Person
				{
					Id = 102,
					Name="Customer 102",
					Email=string.Empty
				}
			};

			return new ObjectResult(persons);
		}

		// GET api/values/5
		[HttpGet("{id}")]
		public string Get(int id)
		{
			return "value";
		}

		// POST api/values
		[HttpPost]
		public void Post([FromBody]string value)
		{
		}

		// PUT api/values/5
		[HttpPut("{id}")]
		public void Put(int id, [FromBody]string value)
		{
		}

		// DELETE api/values/5
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
		}
	}
}