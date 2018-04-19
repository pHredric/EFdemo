using System;
using System.Collections.Generic;

namespace Contacts.Models.Entities
{
    public partial class Contact
    {
        // ID
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
