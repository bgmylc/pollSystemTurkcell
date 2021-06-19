using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pollSystemTurkcell.Models
{
    public class PollUser
    {
        public int UserID { get; set; }
        public User User { get; set; }
        public int PollID { get; set; }
        public Poll Poll { get; set; }


    }
}
