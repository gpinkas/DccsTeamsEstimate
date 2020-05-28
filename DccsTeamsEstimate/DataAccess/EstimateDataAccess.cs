using AutoMapper;
using AutoMapper.QueryableExtensions;
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
        private readonly IMapper _mapper;

        public EstimateDataAccess(EstimateDbContext dbContext, IMapper mapper)
        {
            _mapper = mapper;
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<CardView>> GetAllCards()
        {
            return await _dbContext.Cards.ProjectTo<CardView>(_mapper.ConfigurationProvider).ToListAsync();
        }

        public async Task<CardView> CreateCard(CardCreate card)
        {
            var createEntity = new DataModel.Card()
            {
                CreateDateUtc = DateTime.UtcNow,
                Handle = Guid.NewGuid(),
                EstimationMode = card.EstimationMode,
                Name = card.Name
            };

            var created = await _dbContext.Cards.AddAsync(createEntity);
            await _dbContext.SaveChangesAsync();

            return _mapper.Map<CardView>(created.Entity);
        }

        public async Task<EstimateView> CreateEstimate(Guid cardHandle, EstimateCreate estimate)
        {
            var card = await _dbContext.Cards.FirstAsync(c => c.Handle == cardHandle);

            var createEntity = new DataModel.Estimate()
            {
                Card = card,
                CreateDateUtc = DateTime.UtcNow,
                UserName = estimate.UserName,
                Vote = estimate.Vote
            };

            var created = await _dbContext.Estimates.AddAsync(createEntity);
            await _dbContext.SaveChangesAsync();

            return _mapper.Map<EstimateView>(created.Entity);
        }

        public async Task<CardView> GetCard(Guid cardHandle)
        {
            return await _dbContext.Cards.ProjectTo<CardView>(_mapper.ConfigurationProvider).FirstAsync(c => c.Handle == cardHandle);
        }
    }
}
