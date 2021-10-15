using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication23.Models
{
    public class User
    {
      

        [Display(Name ="نام کاربری")]
        [Required(ErrorMessage ="{0} اجباری است")]
        public string Name { get; set; }
        [Display(Name = "کلمه عبور")]
        [Required(ErrorMessage = "{0} اجباری است")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
