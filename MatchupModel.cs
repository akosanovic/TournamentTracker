using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibray
{
    public class MatchupModel
    {
        public TeamModel Winner { get; set; }
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();

        public int MatchupRound { get; set; }
    }
}
