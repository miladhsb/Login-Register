using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication23.Models
{
    public class RegisterUser
    {
        [Required(ErrorMessage ="نام کاربری اجباری است")]
        [Display(Name ="نام کاربری")]
        [MaxLength(10, ErrorMessage ="نام کاربری حد اکثر باید 10 کاراکتر باشد")]
        public string UserName { get; set; }
        [Display(Name = "کلمه عبور")]
        [Required(ErrorMessage = "{0} اجباری است")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Display(Name = "تکرار کلمه عبور")]
        [DataType(DataType.Password)]
        [Compare(nameof(Password),ErrorMessage ="کلمه عبور یکسان نیست")]
        public string ConfirmPassword { get; set; }
    }
}
