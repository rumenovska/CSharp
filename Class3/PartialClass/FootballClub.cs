using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass
{
    public partial class FootballClub
    {
        public string Name { get; set; }
        public string City { get; set; }
        public string stadium { get; set; }
        public Dictionary<string, int> TeamLineUp{ get; set; }


    }
}
