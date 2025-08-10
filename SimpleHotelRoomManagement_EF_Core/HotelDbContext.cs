using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleHotelRoomManagement_EF_Core.Models;


namespace SimpleHotelRoomManagement_EF_Core
{
    public class HotelDbContext : DbContext
    {
        //to override the OnConfiguring method to set the connection string ...
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-OGTF9QH;Initial Catalog=HotelDB;Integrated Security=True;TrustServerCertificate=True");
        }

        // DbSet properties for each model class
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Guest> Guests { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Rating> Ratings { get; set; }

        // Override OnModelCreating to configure relationships and constraints
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    // Booking relationship
        //    modelBuilder.Entity<Booking>()
        //        .HasOne(b => b.Guest)
        //        .WithMany(g => g.GuestBooking)
        //        .HasForeignKey(b => b.GuestId);

        //    modelBuilder.Entity<Booking>()
        //        .HasOne(b => b.Room)
        //        .WithMany(r => r.RoomBooking)
        //        .HasForeignKey(b => b.RoomNumber);

        //    // Rating relationship
        //    modelBuilder.Entity<Rating>()
        //        .HasOne(r => r.Guest)
        //        .WithMany(g => g.GuestRating)
        //        .HasForeignKey(r => r.GuestId);

        //    modelBuilder.Entity<Rating>()
        //        .HasOne(r => r.Room)
        //        .WithMany(ro => ro.RoomRating)
        //        .HasForeignKey(r => r.RoomNumber);
        //}


    }
}
