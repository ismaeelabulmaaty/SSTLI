using Microsoft.EntityFrameworkCore;
using SSTLI.Models;

namespace SSTLI.Data
{
    public class SstliDbContext : DbContext
    {

        public SstliDbContext(DbContextOptions<SstliDbContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RegistrationAttendanceOrOnline>(entity =>
            {
                entity.Property(e => e.attachNationalIdImage)
                      .HasColumnType("NVARCHAR(MAX)")
                      .IsRequired(true);

                entity.Property(e => e.AttachEducationalQualificationImage)
                      .HasColumnType("NVARCHAR(MAX)")
                      .IsRequired(true);

                entity.Property(e => e.Signature)
                      .HasColumnType("NVARCHAR(MAX)")
                      .IsRequired(true);
            });

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<RegistrationAttendanceOrOnline> RegistrationsAttendanceOrOnline { get; set; }
    }
}
