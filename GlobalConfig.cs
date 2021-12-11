using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibray
{
    public static class GlobalConfig
    {
        // everyone can read the value of Connections
        // only properties inside of GlobalConfig Class can set the value of Connections
        // Connections set as list - can use 2 data connections at the same time 

        public static List<IDataConnection> Connections { get; private set; }


        public static void InitializeConnections(bool database, bool textFiles)
        {

        }
    }
}
