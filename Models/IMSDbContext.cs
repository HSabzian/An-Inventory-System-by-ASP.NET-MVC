//using Microsoft.EntityFrameworkCore;

//namespace InventoryManagementSystem.Models
//{
//    public class IMSDbContext : DbContext
//    {
//        public IMSDbContext(DbContextOptions options):base(options)
//        {

//        }
//        public DbSet<User>Users { get; set; }
//        public DbSet<Designation>Designation { get; set; }
//        public DbSet<Employee>Employee { get; set; }
//    }
//}

using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryManagementSystem.Models
{
    public class IMSDbContext : DbContext
    {
        public IMSDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Designation> Designation { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Location> Location { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<AssetMaster> AssetMaster { get; set; }
        public DbSet<VendorMaster> VendorMaster { get; set; }
        public DbSet<AssetProcurement> AssetProcurement { get; set; }
        public DbSet<AssetDeployement> AssetDeployement { get; set; }
        public DbSet<AssetAquisation> AssetAquisation { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed User Data
            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, SerialNumber = 55, UserId = 1, Name = "Hossein", Email = "Hossein.Sabzian@maine.edu", Password = "RyanLove@@10", Status = "Active", by = "Today", when = DateTime.Now }
            );

            // Seed VendorMaster Data
            modelBuilder.Entity<VendorMaster>().HasData(
                new VendorMaster { VMid = 1, SerialNumber = 101, VendorName = "TechVendor", VendorDescription = "Provides hardware" }
            );

            // Seed Designation Data
            modelBuilder.Entity<Designation>().HasData(
                new Designation { Did = 1, SerialNumber = 201, DesignationName = "Manager", DesignaionDescription = "Manages teams", Status = "Active" }
            );

            // Seed Department Data
            modelBuilder.Entity<Department>().HasData(
                new Department { Depid = 1, SerialNumber = 301, DepartmentName = "HR", DepartmentDescription = "Human Resources", Status = "Active" }
            );

            // Seed Location Data
            modelBuilder.Entity<Location>().HasData(
                new Location { Lid = 1, SerialNumber = 401, LocationName = "HQ", LocationDescription = "Headquarters", Status = "Active" },
                 new Location { Lid = 2, SerialNumber = 402, LocationName = "Inventory", LocationDescription = "Headquarters", Status = "Active" }
            );

            // Seed Employee Data
            modelBuilder.Entity<Employee>().HasData(
                new Employee { Eid = 1, Serialnumber = 501, EmpId = 1, FirstName = "John", LastName = "Doe", Email = "john.doe@example.com", Phone = "1234567890", Status = "Active", DesignationId = 1, DepartmentId = 1, LocationId = 1, DateOfBirth = new DateTime(1990, 1, 1), DateOfJoining = new DateTime(2020, 1, 1) }
            );

            // Seed AssetMaster Data
            modelBuilder.Entity<AssetMaster>().HasData(
                new AssetMaster { AMid = 1, SerialNumber = 601, AssetName = "Laptop", AssetModel = "Dell XPS", AssetDescription = "Dell XPS 13" }
            );

            // Seed AssetProcurement Data
            modelBuilder.Entity<AssetProcurement>().HasData(
                new AssetProcurement { APid = 1, SerialNumber = 701, AssetMasterId = 1, VendorMasterId = 1, PurchaseOrder = 1001, PurchaseDate = DateTime.Now, QuotationNumber = 10001, Quantity = 10, DeliveryDate = DateTime.Now.AddDays(7), Status = "Delivered", Remark = "On Time" }
            );

            // Seed AssetDeployement Data
            modelBuilder.Entity<AssetDeployement>().HasData(
                new AssetDeployement { ADid = 1, SerialNumber = 801, AssetMasterId = 1, VendorMasterId = 1, EmployeeId = 1, IssueDate = DateTime.Now, DepartmentId = 1, Status = "Deployed", Remark = "Deployed Successfully" }
            );

            // Seed AssetAquisation Data
            modelBuilder.Entity<AssetAquisation>().HasData(
                new AssetAquisation { AAid = 1, SerialNumber = 901, AssetMasterId = 1, VendorMasterId = 1, EmployeeId = 1, ReceivedDate = DateTime.Now, Status = "Received", Remark = "Received Successfully" }
            );
        }






    }
}

