using System;
using System.Collections.Generic;
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
        public Question Question { get; set; }
        public int RespondentID { get; set; }
        public User Respondent { get; set; }
        public bool Answer { get; set; } 
        public string Notes { get; set; } //If users want to add notes to their answers, they can use this

        //TODO 4: En son Login sayfasını yaptım, kullanıcı oluşturma sayfası da düşünülebilir
        //TODO 5: Normal kullanıcının poll listesi sayfasına erişmesi için layouttaki dropdownı düzelt



    }
}
