using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ToiletProject.ViewModels
{
    public class LoginUserViewModel
    {
        [Display(Name = "User Name")]
        [Required(ErrorMessage = "Please Enter User Name")]
        public string Name { get; set; }

        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        [MinLength(8)]
        [Required(ErrorMessage = "Please Enter Password")]
        public string Password { get; set; }
    }
}
