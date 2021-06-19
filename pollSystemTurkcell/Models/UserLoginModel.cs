using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace pollSystemTurkcell.Models
{
    public class UserLoginModel
    {
        [Required(ErrorMessage = "Lütfen kullanıcı adını boş bırakmayınız.")]
        [Display(Name = "Kullanıcı Adı ")]
        public string UserName { get; set; }
      
        [Required(ErrorMessage = "Lütfen şifrenizi giriniz.")]
        [DataType(DataType.Password)]
        [Display(Name = "Şifre")]
        public string Password { get; set; }
    }
}
