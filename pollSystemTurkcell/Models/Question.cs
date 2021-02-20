using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pollSystemTurkcell.Models
{
    public class Question
    {
        public int ID { get; set; }
        public string Text { get; set; }
        public string Options { get; set; } //TODO 1: Burası ile ne yapabilirim?
        public int PollID { get; set; }
        public Poll Poll { get; set; }


    }
}
