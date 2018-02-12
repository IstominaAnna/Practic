using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication4.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;


namespace WebApplication4
{
    public class Context : DbContext
    {
        public Context() : base("Context")
        {
        }

        public DbSet<Runner> Runners { get; set; }
        public DbSet<Charity> Charities { get; set; }
        public DbSet<Gender> Genders{ get; set; }
        public DbSet<Registration> GRegistrations { get; set; }
        public DbSet<Result> Results { get; set; }
        public DbSet<Sponsorship> Sponsorship { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Volunteer> Volunteers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}