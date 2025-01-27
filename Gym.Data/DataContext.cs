

using Gym.Core.Entities;
using Gym.Core.Interface;
using Microsoft.EntityFrameworkCore;

namespace Gym.Data
{
     public class DataContext :DbContext, IDataContext
    {
        public   DbSet<Trainer> TrainerList { get; set; }
        public DbSet<Lesson> LessonList { get; set; }
        public DbSet<Client> ClientList { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=GymAPI_db");
        }
        public  DataContext()
        {
          
        }

    }
}
