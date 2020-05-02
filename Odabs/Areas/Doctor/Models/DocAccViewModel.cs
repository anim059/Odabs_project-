using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Odabs.Areas.Doctor.Models
{
    public class DocAccViewModel
    {
    }

    public class DoctorLoginViewModel
    {
        [Required]
        [Display(Name = "UserName")]

        public string UserName { get; set; }


        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }
}