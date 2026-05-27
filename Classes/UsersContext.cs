using ChatStudents_Bartova.Classes.Common;
using ChatStudents_Bartova.Models;
using Microsoft.EntityFrameworkCore;

namespace ChatStudents_Bartova.Classes
{
    public class UsersContext: DbContext
    {
        public DbSet<Users> Users { get; set; }
        public UsersContext()=>
            Database.EnsureCreated();
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)=>
            optionsBuilder.UseSqlServer(Config.config);
        
    }
}
