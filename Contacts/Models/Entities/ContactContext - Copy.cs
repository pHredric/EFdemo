using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Contacts.Models.Entities
{
    public partial class ContactContext : DbContext
    {
        public ContactContext(DbContextOptions<ContactContext> options)
            :base(options)
        {


        }
    }
}
