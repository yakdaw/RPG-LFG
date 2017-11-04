using System.Collections.Generic;

namespace CodingKobold.LFG.Domain.Entities
{
    public enum Gender { Male, Female }

    public class Player
    {
        public string Nickname { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public string City { get; set; }

        public LoginInfo LoginInfo { get; set; }
        public Profile Profile { get; set; }

        public List<RpgSystem> RpgSystems { get; set; }
        public List<Group> Groups { get; set; }
        public List<Event> Events { get; set; }
        public List<Meeting> Meetings { get; set; }

        public Player(string nickname)
        {
            Nickname = nickname;
            LoginInfo = new LoginInfo();
            Profile = new Profile();
        }
    }
}
