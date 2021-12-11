using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibray
{
    public class MatchupEntryModel
    {
        /// <summary>
        /// Represents one team in the matchup 
        /// </summary>
        public TeamModel TeamCometing { get; set; }
        
        /// <summary>
        ///  Score for this particular team
        /// </summary>
        public double Score { get; set; }
        
        /// <summary>
        /// Points to the matchup this team came from as a winner 
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="initialScore"></param>
        public MatchupEntryModel(double initialScore)
        {
            Console.WriteLine(initialScore);
        }
    }
}
