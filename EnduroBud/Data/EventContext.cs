using EnduroBud.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnduroBud
{
    public class EventContext : DbContext
    {
        public DbSet<Event> Events { get; set; }


        public EventContext(DbContextOptions<EventContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }


}
