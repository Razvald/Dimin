using Microsoft.EntityFrameworkCore;

namespace LogProject.Database
{
    public class AppDbContext : DbContext
    {
        public DbSet<GeologicalObject> GeologicalObjects { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Equipment> Equipments { get; set; }
        public DbSet<MeasurementProtocol> MeasurementProtocols { get; set; }
        public DbSet<Measurement> Measurements { get; set; }
        public DbSet<Report> Reports { get; set; }

        public AppDbContext() : base()
        {
            //Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Дома
            /*optionsBuilder.UseSqlServer("Server=(local); " +
                "Database=Dimin; " +
                "Integrated Security=true;");*/

            // Колледж
            optionsBuilder.UseSqlServer("Data Source=DBSRV\\AG2023; " +
                "Initial Catalog=Dimin; " +
                "Integrated Security=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            SeedData(modelBuilder);
        }

        private static void SeedData(ModelBuilder modelBuilder)
        {
            List<User> users = new()
            {
                new() { ID = 1, Login = "1", Password = "1", Role = Role.Admin },
                new() { ID = 2, Login = "2", Password = "2", Role = Role.Worker },
                new() { ID = 3, Login = "3", Password = "3", Role = Role.Worker }
            };
            List<GeologicalObject> geologicalObjects = new()
            {
                new() { ID = 1, Depth = 123, Type = ObjectType.Fossil, XCoordinates = 12, YCoordinates = 34 },
                new() { ID = 2, Depth = 80, Type = ObjectType.Rock, XCoordinates = 45, YCoordinates = 31 },
                new() { ID = 3, Depth = 55, Type = ObjectType.Mineral, XCoordinates = 41, YCoordinates = 1 },
                new() { ID = 4, Depth = 2, Type = ObjectType.Fossil, XCoordinates = 2, YCoordinates = 74 },
                new() { ID = 5, Depth = 7, Type = ObjectType.Rock, XCoordinates = 63, YCoordinates = 3 },
                new() { ID = 6, Depth = 11, Type = ObjectType.Mineral, XCoordinates = 31, YCoordinates = 64 }
            };
            List<Equipment> equipments = new()
            {
                new() { ID = 1, Name = "For fossil", Availability = ObjectType.Fossil },
                new() { ID = 2, Name = "For rock", Availability = ObjectType.Rock }
            };
            List<MeasurementProtocol> measurementProtocols = new()
            {
                new() { ID = 1, Parameter = 123, MeasurementDate = new DateTime(2024, 4, 15), EquipmentID = 1 },
                new() { ID = 2, Parameter = 87, MeasurementDate = new DateTime(2024, 4, 16), EquipmentID = 2 }
            };
            List<Measurement> measurements = new()
            {
                new() { ID = 1, MeasurementProtocolID = 1, GeologicalObjectID = 1 },
                new() { ID = 2, MeasurementProtocolID = 2, GeologicalObjectID = 2 }
            };
            List<Report> reports = new()
            {
                new() { ID = 1, MeasurementProtocolID = 1, UserID = 2 },
                new() { ID = 2, MeasurementProtocolID = 2, UserID = 3 }
            };

            modelBuilder.Entity<User>().HasData(users);
            modelBuilder.Entity<GeologicalObject>().HasData(geologicalObjects);
            modelBuilder.Entity<Equipment>().HasData(equipments);
            modelBuilder.Entity<MeasurementProtocol>().HasData(measurementProtocols);
            modelBuilder.Entity<Measurement>().HasData(measurements);
            modelBuilder.Entity<Report>().HasData(reports);
        }
    }
}
