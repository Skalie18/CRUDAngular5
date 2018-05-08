namespace CRUDAngular5.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Employee : DbContext
    {
        public Employee()
            : base("name=Employees")
        {
        }

        public virtual DbSet<Employees> Employees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employees>()
                .Property(e => e.EmpCode)
                .IsUnicode(false);

            modelBuilder.Entity<Employees>()
                .Property(e => e.EmpDivision)
                .IsUnicode(false);

            modelBuilder.Entity<Employees>()
                .Property(e => e.EmpDepartment)
                .IsUnicode(false);
        }
    }
}
