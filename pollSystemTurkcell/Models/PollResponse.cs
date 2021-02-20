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
        public string Answer { get; set; } //TODO 2: Bu string mi olmalı yoksa boolean mi, düşün?
        public string Notes { get; set; } //If users want to add notes to their answers, they can use this

        //TODO 3: Dedim ki en son bir user çok poll, bir poll çok user + bir poll çok question, bir question bir poll
        //TODO 4: En son Login sayfasını yaptım, kullanıcı oluşturma sayfası da düşünülebilir
        //TODO 5: Database oluşturmalı mıyım bu noktada bilemedim? Ya da zıbam diye controller ve viewlara mı geçeyim?



    }
}
