using DccsTeamsEstimate.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DccsTeamsEstimate.DataAccess
{
    public interface IEstimateDataAccess
    {
        Task<IEnumerable<CardView>> GetAllCards();

        Task<CardView> CreateCard(CardCreate card);
        
        Task<EstimateView> CreateEstimate(Guid cardHandle, EstimateCreate estimate);
        
        Task<CardView> GetCard(Guid cardHandle);
    }
}