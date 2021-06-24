using loan.Models;
using loan.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace loan.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoanController : ControllerBase
    {
        private readonly ILoanService _Service;
        

        public LoanController(ILoanService Service)
        {
            _Service = Service;

        }

        [HttpPost("Applyloan")]
        public IActionResult ApplyLoan([FromBody] Loan loan)
        {
            if (loan == null)
            {
                return BadRequest("Please Provide Data");
            }
            else
            {
                _Service.AddLoan(loan);
                return Ok("User Added");
            }
        }
        // GET: api/<LoanController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<LoanController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<LoanController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<LoanController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<LoanController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
