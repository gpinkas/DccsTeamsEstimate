using DccsTeamsEstimate.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DccsTeamsEstimate.DataAccess
{
    public interface IEstimateDataAccess
    {
        Task<IEnumerable<Card>> GetAllCards();
    }
}