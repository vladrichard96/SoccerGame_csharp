using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soccer
{
    public class Team
    {
        public string Name, Skin, Hair, Shirt, Stripes, Shorts, Socks;
        public int Goals;
    }

    public class HomeTeam : Team { }
    public class AwayTeam : Team { }
}
