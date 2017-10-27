using System;
using System.Collections.Generic;

namespace CodingKobold.LFG.Domain.Entities
{
    public class Meeting
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }

        public Player Organizer { get; set; }
        public List<Player> Players { get; set; }
    }
}
