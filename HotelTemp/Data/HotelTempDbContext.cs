using HotelTemp.Controllers;
using HotelTemp.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

namespace HotelTemp.Data
{
    public class HotelTempDbContext : DbContext
    {
        public HotelTempDbContext(DbContextOptions<HotelTempDbContext> options) : base(options)
        {

        }

        //Models
        public DbSet<Home> Home { get; set; }
        public DbSet<About> About { get; set; }
        public DbSet<Testimonial> Testimonial { get; set; }
        public DbSet<Team> Team { get; set; }
        public DbSet<Service> Service { get; set; }
        public DbSet<Room> Room { get; set; }
        //public DbSet<Feature> Feature { get; set; }
        //public DbSet<RoomOfFeature> RoomOfFeature { get; set; }




    }


}
