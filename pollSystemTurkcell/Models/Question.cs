using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace pollSystemTurkcell.Models
{
    public class Question
    {
        public int ID { get; set; }
        [Display(Name = "Soru")]
        public string Text { get; set; }
        public int PollID { get; set; }
        public Poll Poll { get; set; }

        public IList<PollResponse> PollResponses { get; set; }
    }
}
