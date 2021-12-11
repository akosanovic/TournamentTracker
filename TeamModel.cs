using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibray
{
    public class TeamModel
    {
        public string TeamName { get; set; }

        /// <summary>
        ///   Instead of instantating TeamMembers list in a constructor - old way
        ///   Initialize TeamMember every time TeamModel class is instantiated
        ///   
        ///  public TeamModel()
        ///  {
        ///    TeamMembers = new List<Person>();
        ///   }
        /// 
        /// </summary>
       
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();




    }
}
