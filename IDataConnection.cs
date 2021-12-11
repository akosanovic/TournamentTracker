using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibray
{
    public interface IDataConnection
    {
        // interface contains only public items 
        // doesn't contain code 
        // classes that implement interface must  contain method CreatePrize 
        // code inside individual classes cand be significally different  

        PrizeModel CreatePrize(PrizeModel model); // contract for method  

    }
}
