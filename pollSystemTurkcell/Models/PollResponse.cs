using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace pollSystemTurkcell.Models
{
    public class PollResponse
    {
        public int ID { get; set; }
        public int PollID { get; set; }
        public Poll Poll { get; set; }
       
        public int QuestionID { get; set; }
        [Display(Name = "Soru")]
        public Question Question { get; set; }
       
        public int RespondentID { get; set; }
        [Display(Name = "Cevaplayan")]
        public User Respondent { get; set; }

        [Display(Name = "Cevap")]
        public bool Answer { get; set; } //They can answer with yes or no

        [Display(Name = "Eklemek istediğiniz notlar")]
        public string Notes { get; set; } //If users want to add notes to their answers, they can use this

        //TODO 4: En son Login sayfasını yaptım, kullanıcı oluşturma sayfası da düşünülebilir
        


    }
}
