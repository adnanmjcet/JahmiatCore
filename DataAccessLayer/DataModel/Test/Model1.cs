namespace DataAccessLayer.DataModel.Test
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model11")
        {
        }

        public virtual DbSet<EventRequest> EventRequests { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EventRequest>()
                .Property(e => e.EventName)
                .IsUnicode(false);

            modelBuilder.Entity<EventRequest>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<EventRequest>()
                .Property(e => e.TotalSpeakers)
                .IsUnicode(false);

            modelBuilder.Entity<EventRequest>()
                .Property(e => e.Venu)
                .IsUnicode(false);
        }
    }
}
