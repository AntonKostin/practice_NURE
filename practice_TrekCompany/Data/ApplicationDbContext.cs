using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using practice_TrekCompany.Models.factory;
using practice_TrekCompany.Models.production;
using practice_TrekCompany.Models.spares.sparesEquipment;
using practice_TrekCompany.Models.spares.sparesFrameset;
using practice_TrekCompany.Models.spares.sparesGroopset;
using practice_TrekCompany.Models.spares.sparesTransmition;
using practice_TrekCompany.Models.spares.sparesWheelset;

namespace practice_TrekCompany.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Models.spares.sparesWheelset.Hub> Hubs { get; set; }
        public DbSet<Rim> Rims { get; set; }
        public DbSet<Tire> Tires { get; set; }
        public DbSet<Cassette> Cassettes { get; set; }
        public DbSet<Shifter> Shifters { get; set; }
        public DbSet<Switch> Switches { get; set; }
        public DbSet<Carriage> Carriages { get; set; }
        public DbSet<Pedals> Pedalses { get; set; }
        public DbSet<Transmition> Transmitions { get; set; }
        public DbSet<Fork> Forks { get; set; }
        public DbSet<Frame> Frames { get; set; }
        public DbSet<Brake> Brakes { get; set; }
        public DbSet<Grips> Gripses { get; set; }
        public DbSet<Handlebar> Handlebars { get; set; }
        public DbSet<Saddle> Saddles { get; set; }
        public DbSet<SeatPost> SeatPosts { get; set; }
        public DbSet<Steering> Steerings { get; set; }
        public DbSet<Stem> Stems { get; set; }
        public DbSet<Wheelset> Wheelsets { get; set; }
        public DbSet<Groopset> Groopsets { get; set; }
        public DbSet<Frameset> Framesets { get; set; }
        public DbSet<Equipment> Equipments { get; set; }
        public DbSet<Bike> Bikes { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<JobTitle> JobTitles { get; set; }
        public DbSet<Factory> Factories { get; set; }
        public DbSet<TypeOfBike> TypeOfBikes { get; set; }
    }
}