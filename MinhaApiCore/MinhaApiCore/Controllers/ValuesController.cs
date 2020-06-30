using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MinhaApiCore.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ValuesController: ControllerBase
	{
		// GET api/values
		[HttpGet]
		public ActionResult<IEnumerable<string>> Get() {
			return new string[] { "value1", "value2" };
		}

		// GET api/values/5
		[HttpGet("{id}")]
		public ActionResult<string> Get(int id) {
			return "value";
		}

		// POST api/values
		//[HttpPost]
		//[ProducesResponseType(typeof(Product), StatusCodes.Status201Created)]
		//[ProducesResponseType(StatusCodes.Status400BadRequest)]
		//public ActionResult Post(Product product) {
		//	// o 201 retorna o status de Ok e Criado
		//	// o 200 retorna somente o Ok
		//	if(product.Id == 0) return BadRequest();
		//
		//	//Ad no banco
		//	//return CreatedAtAction("Post", product);
		//	return Ok();
		//}

		// PUT api/values/5
		[HttpPut("{id}")]
		public void Put(int id, [FromBody] string value) {
		}

		// DELETE api/values/5
		[HttpDelete("{id}")]
		public void Delete(int id) {
		}
	}
}
