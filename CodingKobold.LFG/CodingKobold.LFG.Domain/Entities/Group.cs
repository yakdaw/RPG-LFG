using System.Collections.Generic;

namespace CodingKobold.LFG.Domain.Entities
{
    public class Group
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public Player Owner { get; set; }
        public List<Player> Players { get; set; }

        public List<RpgSystem> RpgSystems { get; set; }
    }
}
