using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pollSystemTurkcell.Models
{
    public class Poll
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Details { get; set; }
        public int NoOfConfirmations { get; set; }
        public DateTime Deadline { get; set; }
        public DateTime CreationDate { get; set; }
        public int CreatorID { get; set; }
        public User Creator { get; set; }

        public IList<Question> Questions { get; set; }
        public IList<PollUser> User { get; set; }

    }
}
