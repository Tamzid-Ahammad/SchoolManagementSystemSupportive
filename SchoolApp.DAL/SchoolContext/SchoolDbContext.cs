using Microsoft.EntityFrameworkCore;
using SchoolApp.Models.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
namespace SchoolApp.DAL.SchoolContext
{
    public class SchoolDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, Guid,
        ApplicationUserClaim, ApplicationUserRole, ApplicationUserLogin,
        ApplicationRoleClaim, ApplicationUserToken>
    {
        public DbSet<AcademicYearMonth> AcademicYearMonths { get; set; }
        public DbSet<AcademicYear> AcademicYears { get; set; }
        public DbSet<Admission> Admissions { get; set; }
        public DbSet<Attendance> Attendances { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<ClassSection> ClassSections { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<DepartmentDesignation> DepartmentDesignations { get; set; }
        public DbSet<Designation> Designations { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Exam> Exams { get; set; }
        public DbSet<ExamSchedule> ExamSchedules { get; set; }
        public DbSet<FeePayment> FeePayments { get; set; }
        public DbSet<FeeStructure> FeeStructures { get; set; }
        public DbSet<FeeType> FeeTypes { get; set; }
        public DbSet<Parent> Parents { get; set; }
        public DbSet<Resource> Resources { get; set; }
        public DbSet<Section> Sections { get; set; }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Teacher> Teachers { get; set; }

        public SchoolDbContext(DbContextOptions<SchoolDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<ApplicationUser>(b =>
            {
                b.HasMany(e => e.Claims)
                    .WithOne(e => e.User)
                    .HasForeignKey(uc => uc.UserId)
                    .IsRequired();
                b.HasMany(e => e.Logins)
                    .WithOne(e => e.User)
                    .HasForeignKey(ul => ul.UserId)
                    .IsRequired();
                b.HasMany(e => e.Tokens)
                    .WithOne(e => e.User)
                    .HasForeignKey(ut => ut.UserId)
                    .IsRequired();
                b.HasMany(e => e.UserRoles)
                    .WithOne(e => e.User)
                    .HasForeignKey(ur => ur.UserId)
                    .IsRequired();
                b.HasOne(a => a.Father)
                    .WithOne(b => b.Father)
                    .HasForeignKey<Parent>(b => b.FatherId);
                b.HasOne(a => a.Mother)
                    .WithOne(b => b.Mother)
                    .HasForeignKey<Parent>(b => b.MotherId);
            });

            builder.Entity<ApplicationRole>(b =>
            {
                b.HasMany(e => e.UserRoles)
                    .WithOne(e => e.Role)
                    .HasForeignKey(ur => ur.RoleId)
                    .IsRequired();
                b.HasMany(e => e.RoleClaims)
                    .WithOne(e => e.Role)
                    .HasForeignKey(rc => rc.RoleId)
                    .IsRequired();
            });

            builder.Entity<Teacher>(b =>
            {
                b.HasMany(e => e.AlternativeTeacherRoutines)
                    .WithOne(e => e.AlternativeTeacher)
                    .HasForeignKey(e => e.AlternativeTeacherId);
                b.HasMany(e => e.TeacherRoutines)
                    .WithOne(e => e.Teacher)
                    .HasForeignKey(e => e.TeacherId)
                    .IsRequired();
            });
        }
    }
}
