using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Contacts.Models
{
    public class Person
    {
        public int Id { get; set; }

        [StringLength(40, MinimumLength = 2)]
        [Required(ErrorMessage = "Du måste skriva in ett namn")]
        public string Name { get; set; }

        [StringLength(40, MinimumLength = 6)]
        [Required(ErrorMessage ="Du måste skriva in en giltig mailaddress")]
        [EmailAddress]
        public string Email { get; set; }

    }
}
