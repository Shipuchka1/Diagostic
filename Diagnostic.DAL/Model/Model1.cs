namespace Diagnostic.DAL.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=hDiagnostic")
        {
        }

        public virtual DbSet<pn_tests> pn_tests { get; set; }
        public virtual DbSet<pn_laboratory> pn_laboratory { get; set; }
        public virtual DbSet<pn_city> pn_city { get; set; }
        public virtual DbSet<pn_roles> pn_roles { get; set; }
        public virtual DbSet<pn_tbl_user> pn_tbl_user { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<pn_roles>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<pn_tbl_user>()
                .Property(e => e.login)
                .IsUnicode(false);

            modelBuilder.Entity<pn_tbl_user>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<pn_tbl_user>()
                .Property(e => e.address)
                .IsUnicode(false);

            modelBuilder.Entity<pn_tbl_user>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<pn_tbl_user>()
                .Property(e => e.phoneNo)
                .IsUnicode(false);

            modelBuilder.Entity<pn_city>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<pn_laboratory>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<pn_laboratory>()
                .Property(e => e.address)
                .IsUnicode(false);

            modelBuilder.Entity<pn_laboratory>()
                .Property(e => e.labeTimins)
                .IsUnicode(false);

            modelBuilder.Entity<pn_laboratory>()
                .Property(e => e.phoneNo)
                .IsUnicode(false);

            modelBuilder.Entity<pn_tests>()
                .Property(e => e.name)
                .IsUnicode(false);


        }
    }
}
