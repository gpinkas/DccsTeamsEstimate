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
        private readonly IEstimateDataAccess _dataAccess;

        public EstimateController(ILogger<EstimateController> logger, IEstimateDataAccess dataAccess)
        {
            _logger = logger;
            _dataAccess = dataAccess;
        }

        [HttpGet]
        public async Task<IEnumerable<CardView>> GetCards()
        {
            return await _dataAccess.GetAllCards();
        }

        [HttpPost("init")]
        public async Task<CardView> Initialize([FromBody]CardCreate card)
        {
            return await _dataAccess.CreateCard(card);
        }

        [HttpPost("{cardHandle}/vote")]
        public async Task<EstimateView> Vote([FromRoute]Guid cardHandle, [FromBody]EstimateCreate estimate)
        {
            return await _dataAccess.CreateEstimate(cardHandle, estimate);
        }

        [HttpGet("{cardHandle}")]
        public async Task<CardView> Reveal([FromRoute]Guid cardHandle)
        {
            return await _dataAccess.GetCard(cardHandle);
        }
    }
}
