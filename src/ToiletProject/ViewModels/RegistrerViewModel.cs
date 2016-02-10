using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ToiletProject.ViewModels
{
    public class RegistrerViewModel
    {
        [Display(Name= "Name")]
        [Required(ErrorMessage ="Required field")]
        public string Name { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "Required field")]
        public string Password { get; set; }

        [Display(Name = "E-mail")]
        [Required(ErrorMessage = "Required field")]
        public string EMail { get; set; }
    }
}
