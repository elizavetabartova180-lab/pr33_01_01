using System;
using System.Collections.Generic;
using System.Text;
using ChatStudents_Bartova.Classes.Common;
using ChatStudents_Bartova.Models;
using Microsoft.EntityFrameworkCore;

namespace ChatStudents_Bartova.Classes
{
    public class MessagesContext : DbContext
    {
        public DbSet<Messages> Messages { get; set; }
        public MessagesContext() =>
            Database.EnsureCreated();
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.UseSqlServer(Config.config);
    }
}
