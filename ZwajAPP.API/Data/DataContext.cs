using Microsoft.EntityFrameworkCore;

using ZwajAPP.API.Models;

namespace ZwajAPP.API.Data {

   public class DataContext : DbContext {
      public DataContext(DbContextOptions<DataContext> options) : base (options) { }
      public DbSet<Value> Value { get; set; }
      // public DbSet<User> Users { get; set; }
   }
}