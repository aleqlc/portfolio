namespace WpfStudentManagementSysWithDbFirstApproach.EntityModel
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class StudentContext : DbContext
    {
        public StudentContext()
            : base("name=StudentContext2")
        {
        }

        public virtual DbSet<tblInfo> tblInfoes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tblInfo>()
                .Property(e => e.StudentName)
                .IsUnicode(false);

            modelBuilder.Entity<tblInfo>()
                .Property(e => e.Class)
                .IsUnicode(false);

            modelBuilder.Entity<tblInfo>()
                .Property(e => e.Subject)
                .IsUnicode(false);

            modelBuilder.Entity<tblInfo>()
                .Property(e => e.FatherName)
                .IsUnicode(false);

            modelBuilder.Entity<tblInfo>()
                .Property(e => e.Address)
                .IsUnicode(false);
        }
    }
}
