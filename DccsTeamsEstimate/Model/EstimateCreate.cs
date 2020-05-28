using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DccsTeamsEstimate.Model
{
    public class EstimateCreate
    {
        public string UserName { get; set; }

        public int Vote { get; set; }
    }
}
