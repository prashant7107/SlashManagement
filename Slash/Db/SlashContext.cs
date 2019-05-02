namespace Slash.Db
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class SlashContext : DbContext
    {
        public SlashContext()
            : base("name=SlashContext")
        {
        }

        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Course_List> Course_List { get; set; }
        public virtual DbSet<Hour> Hours { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<Student_Education> Student_Education { get; set; }
        public virtual DbSet<Student_Entry> Student_Entry { get; set; }
        public virtual DbSet<Student_Photo> Student_Photo { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Teachers_List> Teachers_List { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Admin>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Admin>()
                .Property(e => e.Username)
                .IsFixedLength();

            modelBuilder.Entity<Admin>()
                .Property(e => e.Password)
                .IsFixedLength();

            modelBuilder.Entity<Course_List>()
                .Property(e => e.Subject)
                .IsFixedLength();

            modelBuilder.Entity<Hour>()
                .Property(e => e.displaym)
                .IsFixedLength();

            modelBuilder.Entity<Student_Education>()
                .Property(e => e.Education)
                .IsFixedLength();

            modelBuilder.Entity<Student_Entry>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<Student_Entry>()
                .Property(e => e.Gender)
                .IsFixedLength();

            modelBuilder.Entity<Student_Entry>()
                .Property(e => e.Address)
                .IsFixedLength();

            modelBuilder.Entity<Student_Entry>()
                .Property(e => e.Code)
                .IsFixedLength();

            modelBuilder.Entity<Student_Entry>()
                .Property(e => e.Email_Id)
                .IsFixedLength();

            modelBuilder.Entity<Student_Entry>()
                .Property(e => e.Remarks)
                .IsFixedLength();

            modelBuilder.Entity<Student_Photo>()
                .HasMany(e => e.Student_Entry)
                .WithOptional(e => e.Student_Photo)
                .HasForeignKey(e => e.PhotoId);

            modelBuilder.Entity<Teachers_List>()
                .Property(e => e.Teacher)
                .IsFixedLength();

            modelBuilder.Entity<Teachers_List>()
                .Property(e => e.Subjects)
                .IsUnicode(false);

            modelBuilder.Entity<Teachers_List>()
                .Property(e => e.Remarks)
                .IsUnicode(false);

            modelBuilder.Entity<Teachers_List>()
                .Property(e => e.Email)
                .IsUnicode(false);

        }
    }
}
