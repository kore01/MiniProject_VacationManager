using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project_Vacation_Manager.ViewModels
{
    public class EditUserViewModel
    {
        public EditUserViewModel()
        {
           // Claims = new List<string>();
            Roles = new List<string>();
        }

        public string Id { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Team { get; set; }

        //public List<string> Claims { get; set; }

        public IList<string> Roles { get; set; }
    }
}
