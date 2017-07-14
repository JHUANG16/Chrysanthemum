using Microsoft.EntityFrameworkCore;

namespace Chrysanthemum.Models
{
    public class ContactContext:DbContext
    {
        public DbSet<Contact> Contacts { get; set;}
    }

}