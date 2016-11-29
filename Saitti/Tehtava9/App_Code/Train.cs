using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JAMK.IT {
    public class Train {
        public Train() {

        }

        public string stationName { get; set; }
        public string stationShortCode { get; set; }
        public int trainNumber { get; set; }
        public string cancelled { get; set; }
        public string type { get; set; }
    }
}