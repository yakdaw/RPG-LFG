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

        public void SetTodayRegisterTime()
        {
            RegisterTime = DateTime.Now.Date;
        }

        public void SetTodayLastSeenTime()
        {
            LastSeenTime = DateTime.Now.Date;
        }
    }
}