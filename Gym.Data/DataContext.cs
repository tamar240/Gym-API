

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
            // TrainerList = new List<Trainer>(){
            //    new Trainer("1", "tamar", "choen", EnumGender.female, "00000", "t@gmail.com", EnumTypesOfFitness.Pilates),
            //    new Trainer("2", "shira", "levi", EnumGender.female, "11111", "t@gmail.com", EnumTypesOfFitness.HIIT)
            //};
            //LessonList = new List<Lesson>()
            //{
            //   new Lesson(EnumTypesOfFitness.Pilates,"1", EnumGender.female,EnumDayOfWeek.Monday,new TimeSpan(20,30,0),45,EnumLevel.Beginner),
            //   new Lesson(EnumTypesOfFitness.Dence,"1", EnumGender.female,EnumDayOfWeek.Monday,new TimeSpan(10,30,0),45,EnumLevel.Beginner),
            //   new Lesson(EnumTypesOfFitness.HIIT,"1", EnumGender.male,EnumDayOfWeek.Sunday,new TimeSpan(12,30,0),45,EnumLevel.Beginner)
            //};
            //ClientList = new List<Client>(){
            //  new Client("1111","tamar","vurzel",EnumGender.female,"200000","khjkhkj",EnumHealthFund. Leumit),
            //  new Client("2222","chya","vurzel",EnumGender.female,"200000","khjkhkj",EnumHealthFund.Meuhedet)

            //};
        }

    }
}
