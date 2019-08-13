namespace Maps.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class EventContext : DbContext
    {
        public EventContext()
            : base("name=EventContext")
        {
        }


         public DbSet<Event> Events { get; set; }
    }

}