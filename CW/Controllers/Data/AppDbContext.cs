using CW.Models;
using Microsoft.EntityFrameworkCore;

namespace CW.Controllers.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<UsersModel> Users { get; set; }
        public DbSet<CarsModel> Cars { get; set; }
        public DbSet<RentRequestModel> RentRequests { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        

            modelBuilder.Entity<RentRequestModel>()
                .HasOne(rr => rr.User)
                .WithMany(u => u.RentRequests)
                .HasForeignKey(rr => rr.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<RentRequestModel>()
                .HasOne(rr => rr.Car)
                .WithMany(c => c.RentRequests)
                .HasForeignKey(rr => rr.CarId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<OfferModel>()
                .HasOne(o => o.Staff)
                .WithMany()
                .HasForeignKey(o => o.StaffId);

            modelBuilder.Entity<SalesModel>()
                .HasOne(s => s.Request)
                .WithMany()
                .HasForeignKey(s => s.RequestId);

            modelBuilder.Entity<SalesModel>()
                .HasOne(s => s.Staff)
                .WithMany()
                .HasForeignKey(s => s.StaffId);

            modelBuilder.Entity<RepairModel>()
                .HasOne(r => r.Car)
                .WithMany()
                .HasForeignKey(r => r.CarId);

            modelBuilder.Entity<RepairModel>()
                .HasOne(r => r.User)
                .WithMany()
                .HasForeignKey(r => r.UserId);

            modelBuilder.Entity<VerificationModel>()
                .HasOne(v => v.User)
                .WithMany()
                .HasForeignKey(v => v.UserId);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<UsersModel> User { get; set; }
        public DbSet<AdminModel> Admin { get; set; }

        public DbSet<StaffModel> Staff { get; set; }

        public DbSet<OfferModel> Offer { get; set; }

        public DbSet<SalesModel> Sales { get; set; }

        public DbSet<RepairModel> Repairs { get; set; }

        public DbSet<RentRequestModel> RentRequest { get; set; }

        public DbSet<VerificationModel> Verification { get; set; }

    }
}