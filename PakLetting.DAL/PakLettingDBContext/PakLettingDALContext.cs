using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using PakLetting.Model.PropertyModels;
using PakLetting.Model.CreatorModels;
using PakLetting.Model.SeekerModels;

namespace PakLetting.DAL.PakLettingDBContext
{
    public class PakLettingDALContext : DbContext
    {
        public PakLettingDALContext()
            : base("name=PakLettingCS")
        {
        }

        public DbSet<Property> Property { get; set; }
        public DbSet<Creator> Creator { get; set; }
        public DbSet<Seeker> Seeker { get; set; }
        public DbSet<PropertyType> PropertyType { get; set; }
        public DbSet<Rent> Rent { get; set; }
        public DbSet<Availability> Availability { get; set; }
        public DbSet<TypesOfRent> TypesOfRent { get; set; }
        public DbSet<Sale> Sale { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<Area> Area { get; set; }
        public DbSet<MeasurmentType> MeasurementType { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
