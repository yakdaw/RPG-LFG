using System.Collections.Generic;

namespace CodingKobold.LFG.Domain.Entities
{
    public class Player
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }

        public List<RpgSystem> RpgSystems { get; set; }

        public List<Group> Groups { get; set; }
        public List<Event> Events { get; set; }
        public List<Meeting> Meetings { get; set; }
    }
}
