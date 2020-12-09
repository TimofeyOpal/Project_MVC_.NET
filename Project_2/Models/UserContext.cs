using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_2.Models
{
    public class UserContext : DbContext
    {
        public DbSet<User> Users { get; set; }
      //  public DbSet<ChatModel> ChatMessage { get; set; }
        public UserContext(DbContextOptions<UserContext> options)
            : base(options)
        {
          //  Database.EnsureDeleted();
           // Database.EnsureCreated();
        }
    }
}
