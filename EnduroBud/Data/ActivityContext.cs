using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EnduroBud.Models;

namespace EnduroBud
{
  public class ActivityContext : DbContext
  {
    public DbSet<Activity> Activities {get; set;}


        public ActivityContext(DbContextOptions<ActivityContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}