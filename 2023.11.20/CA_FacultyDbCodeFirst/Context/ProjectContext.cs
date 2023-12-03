using CA_FacultyDbCodeFirst.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace CA_FacultyDbCodeFirst.Context
{
    public class ProjectContext : DbContext
    {
        public DbSet<AcademicStaff> AcademicStaffs { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<SocialClub> SocialClubs { get; set; }
        public DbSet<AdministrativeStaff> AdministrativeStaffs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=YUSUF-PC\\SQLEXPRESS;database=FacultyDbCodeFirst;Trusted_Connection=True;TrustServerCertificate=True;");

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DepartmentAndAcademicStaff>()
                .HasKey(x => new { x.DepartmentId, x.AcademicStaffId });

            modelBuilder.Entity<CourseAndAcademicStaff>()
                .HasKey(x => new { x.CourseId, x.AcademicStaffId });

            modelBuilder.Entity<CourseAndStudent>()
                .HasKey(x => new { x.CourseId, x.StudentId });

            modelBuilder.Entity<DepartmentAndStudent>()
                .HasKey(x => new { x.DeparmantId, x.StudentId });

            modelBuilder.Entity<SocialClubAndStudent>()
                .HasKey(x => new { x.SocialClubId, x.StudentId });

            base.OnModelCreating(modelBuilder);
        }

    }
}
