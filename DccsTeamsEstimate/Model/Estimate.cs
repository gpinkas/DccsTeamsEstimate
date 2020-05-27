using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DccsTeamsEstimate.Model
{
    public class Estimate
    {
        public int Id { get; set; }

        public int CardId { get; set; }

        public DateTime CreateDateUtc { get; set; }

        public int Vote { get; set; }

        [ForeignKey("CardId")]
        public virtual Card Card { get; set; }
    }
}
