

using Gym.Core.Entities;
using Gym.Core.Interface;

namespace Gym.Data
{
     public class DataContext : IDataContext
    {
        public   List<Trainer> TrainerList { get; set; }
        public  List<Lesson> LessonList { get; set; }
        public  List<Client> ClientList { get; set; } 
        public  DataContext()
        {
             TrainerList = new List<Trainer>(){
                new Trainer("1", "tamar", "choen", EnumGender.female, "00000", "t@gmail.com", EnumTypesOfFitness.Pilates),
                new Trainer("2", "shira", "levi", EnumGender.female, "11111", "t@gmail.com", EnumTypesOfFitness.HIIT)
            };
            LessonList = new List<Lesson>()
            {
               new Lesson(EnumTypesOfFitness.Pilates,"1", EnumGender.female,EnumDayOfWeek.Monday,new TimeSpan(20,30,0),45,EnumLevel.Beginner),
               new Lesson(EnumTypesOfFitness.Dence,"1", EnumGender.female,EnumDayOfWeek.Monday,new TimeSpan(10,30,0),45,EnumLevel.Beginner),
               new Lesson(EnumTypesOfFitness.HIIT,"1", EnumGender.male,EnumDayOfWeek.Sunday,new TimeSpan(12,30,0),45,EnumLevel.Beginner)
            };
            ClientList = new List<Client>(){
              new Client("1111","tamar","vurzel",EnumGender.female,"200000","khjkhkj",EnumHealthFund. Leumit),
              new Client("2222","chya","vurzel",EnumGender.female,"200000","khjkhkj",EnumHealthFund.Meuhedet)

            };
        }

    }
}
