using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DccsTeamsEstimate.DataAccess.DataModel
{
    public class Card
    {
        public int Id { get; set; }

        public Guid Handle { get; set; }

        public string Name { get; set; }

        public DateTime CreateDateUtc { get; set; }

        public int EstimationMode { get; set; }

        public virtual List<Estimate> Estimates { get; set; }
    }
}
