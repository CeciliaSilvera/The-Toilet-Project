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
        public string Name { get; set; }

        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "E-mail")]
        public string EMail { get; set; }
    }
}
