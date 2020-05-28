using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DccsTeamsEstimate.Model
{
    public class CardView
    {
        public Guid Handle { get; set; }

        public string Name { get; set; }

        public DateTime CreateDateUtc { get; set; }

        public int EstimationMode { get; set; }

        public virtual List<EstimateView> Estimates { get; set; }
    }
}
