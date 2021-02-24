using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace pollSystemTurkcell.Models
{
    public class Poll
    {
        public int ID { get; set; }

        [Display(Name = "Anket Başlığı ")]
        public string Title { get; set; }

        [Display(Name = "Anket Detayları ")]
        public string Details { get; set; }

        [Display(Name = "Anket İçin Gereken Onay Sayısı ")]
        public int NoOfConfirmations { get; set; }

        [Display(Name = "Anket Kapanış Tarihi ")]
        public DateTime Deadline { get; set; }

        [Display(Name = "Anket Oluşturulma Tarihi ")]
        public DateTime CreationDate { get; set; }

        [Display(Name = "Anketi Oluşturan Admin")]
        public int CreatorID { get; set; }
       
        [Display(Name = "Anketi Oluşturan Admin")]
        public User Creator { get; set; }

        [Display(Name = "Anket Soruları")]
        public IList<Question> Questions { get; set; }
        public IList<PollUser> User { get; set; }
        public IList<PollResponse> PollResponses { get; set; }

    }
}
