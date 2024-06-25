using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TasteFoodIT.Entities;

namespace TasteFoodIT.Context
{
    public class TasteContext : DbContext
    {
        public DbSet<About> Abouts { get; set; }
        public DbSet<Adress> Adresses { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Chef> Chef { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<OpenDayHour> OpenDayHours { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<TestiMonial> TestiMonials { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Notification> Notifications { get; set; }

    }
}