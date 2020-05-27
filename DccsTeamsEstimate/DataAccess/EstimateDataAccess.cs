using DccsTeamsEstimate.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DccsTeamsEstimate.DataAccess
{
    public class EstimateDataAccess : IEstimateDataAccess
    {
        private readonly EstimateDbContext _dbContext;

        public EstimateDataAccess(EstimateDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Card>> GetAllCards()
        {
            return await _dbContext.Cards.ToListAsync();
        }

        public async Task<Card> CreateCard(string cardName)
        {
            var card = new Card()
            {
                CreateDateUtc = DateTime.UtcNow,
                Handle = Guid.NewGuid(),
                EstimationMode = 1,
                Name = cardName
            };

            var entity = await _dbContext.Cards.AddAsync(card);
            await _dbContext.SaveChangesAsync();

            return entity.Entity;
        }

    }
}
