using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DccsTeamsEstimate.DataAccess;
using DccsTeamsEstimate.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DccsTeamsEstimate.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EstimateController : ControllerBase
    {
        private readonly ILogger<EstimateController> _logger;
        private readonly EstimateDataAccess _dataAccess;

        public EstimateController(ILogger<EstimateController> logger, EstimateDataAccess dataAccess)
        {
            _logger = logger;
            _dataAccess = dataAccess;
        }

        [HttpGet]
        public async Task<IEnumerable<Card>> GetCards()
        {
            return await _dataAccess.GetAllCards();
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
