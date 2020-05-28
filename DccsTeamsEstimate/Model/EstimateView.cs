using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DccsTeamsEstimate.Model
{
    public class EstimateView
    {
        public string UserName { get; set; }

        public int Vote { get; set; }

        public DateTime CreateDateUtc { get; set; }
    }
}
