using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.AccessControl;
using System.Web;

namespace Chrysanthemum.Models
{
    public class ToDoDbContext : DbContext
    {
        public DbSet<Gig> Gigs { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public ToDoDbContext() : base("Chrysanthemum")
        {

        }

        public static ToDoDbContext Create()
        {
            return new ToDoDbContext();
        }
    }
}