using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Agp___Agile_Project.Models
{
    public class UserModel
    {
        public int ID { get; set; }

        [Display(Name = "Put your login name")]
        [StringLength(25, MinimumLength = 4)]
        public string Name { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "The password is required")]
        public string Password { get; set; }

        [Display(Name = "Email address")]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                            @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                            @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$",
                            ErrorMessage = "Email is not valid")]
        [Required(ErrorMessage = "The password is required")]
        public string Email { get; set; }
    }

}
