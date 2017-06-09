namespace UIRS1._1.Data
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class UIRS_DB : DbContext
    {
        public UIRS_DB()
            : base("name=UIRS_DB1")
        {
        }

        public virtual DbSet<AUTO_STOP> AUTO_STOP { get; set; }
        public virtual DbSet<MODEL> MODEL { get; set; }
        public virtual DbSet<Obrashenies> Obrashenies { get; set; }
        public virtual DbSet<POINT> POINT { get; set; }
        public virtual DbSet<ROUTE> ROUTE { get; set; }
        public virtual DbSet<StatusObrasheniya> StatusObrasheniya { get; set; }
        public virtual DbSet<STREET> STREET { get; set; }
        public virtual DbSet<TRAM_STOP> TRAM_STOP { get; set; }
        public virtual DbSet<VEHICLE> VEHICLE { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MODEL>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<MODEL>()
                .HasMany(e => e.VEHICLE)
                .WithRequired(e => e.MODEL)
                .HasForeignKey(e => e.MODEL_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Obrashenies>()
                .Property(e => e.Lastname)
                .IsUnicode(false);

            modelBuilder.Entity<Obrashenies>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<Obrashenies>()
                .Property(e => e.Surname)
                .IsUnicode(false);

            modelBuilder.Entity<Obrashenies>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Obrashenies>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Obrashenies>()
                .Property(e => e.Texttreatment)
                .IsUnicode(false);

            modelBuilder.Entity<Obrashenies>()
                .Property(e => e.FIOdriver)
                .IsUnicode(false);

            modelBuilder.Entity<Obrashenies>()
                .Property(e => e.FIOconductor)
                .IsUnicode(false);

            modelBuilder.Entity<Obrashenies>()
                .Property(e => e.FIOdispetcher)
                .IsUnicode(false);

            modelBuilder.Entity<POINT>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<POINT>()
                .Property(e => e.SHORT_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<POINT>()
                .Property(e => e.WKT_DESCRIPTION)
                .IsUnicode(false);

            modelBuilder.Entity<POINT>()
                .Property(e => e.DESCRIPTION)
                .IsUnicode(false);

            modelBuilder.Entity<POINT>()
                .HasOptional(e => e.AUTO_STOP)
                .WithRequired(e => e.POINT);

            modelBuilder.Entity<POINT>()
                .HasMany(e => e.Obrashenies)
                .WithOptional(e => e.POINT)
                .HasForeignKey(e => e.ID_Point);

            modelBuilder.Entity<POINT>()
                .HasOptional(e => e.TRAM_STOP)
                .WithRequired(e => e.POINT);

            modelBuilder.Entity<ROUTE>()
                .Property(e => e.NUMBER)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ROUTE>()
                .Property(e => e.SHORT_NAME)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ROUTE>()
                .HasMany(e => e.Obrashenies)
                .WithOptional(e => e.ROUTE)
                .HasForeignKey(e => e.ID_Route);

            modelBuilder.Entity<StatusObrasheniya>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<StatusObrasheniya>()
                .HasMany(e => e.Obrashenies)
                .WithRequired(e => e.StatusObrasheniya)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<STREET>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<STREET>()
                .HasMany(e => e.AUTO_STOP)
                .WithRequired(e => e.STREET)
                .HasForeignKey(e => e.STREET_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<STREET>()
                .HasMany(e => e.TRAM_STOP)
                .WithRequired(e => e.STREET)
                .HasForeignKey(e => e.STREET_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<VEHICLE>()
                .Property(e => e.STATE_NUMBER)
                .IsUnicode(false);

            modelBuilder.Entity<VEHICLE>()
                .HasMany(e => e.Obrashenies)
                .WithOptional(e => e.VEHICLE)
                .HasForeignKey(e => e.ID_Vehicle);
        }
    }
}
