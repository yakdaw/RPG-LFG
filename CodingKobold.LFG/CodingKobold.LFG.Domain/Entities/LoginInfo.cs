using System;

namespace CodingKobold.LFG.Domain.Entities
{
    public class LoginInfo
    {
        public DateTime RegisterTime { get; set; }
        public DateTime LastSeenTime { get; set; }

        public LoginInfo()
        {
            RegisterTime = new DateTime();
            LastSeenTime = new DateTime();
        }

        public void SetRegisterDate()
        {
            RegisterTime = DateTime.Now.Date;
        }

        public void SetLogoutDate()
        {
            LastSeenTime = DateTime.Now.Date;
        }
    }
}