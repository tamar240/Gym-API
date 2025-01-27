
using Gym.Core.Entities;
using Gym.Core.Interface;

namespace Gym.Data
{
    public class FakeContext : IDataContext
    {
        public List<Trainer> TrainerList { get; set; }
        public List<Lesson> LessonList { get; set; }
        public List<Client> ClientList { get; set; }
       
        public FakeContext()
        {
            TrainerList = new List<Trainer>(){
                new Trainer("1", "golda", "choen", EnumGender.female, "00000", "t@gmail.com", EnumTypesOfFitness.Pilates),
            };
            LessonList = new List<Lesson>()
            {
               //new Lesson(EnumTypesOfFitness.Pilates,1, EnumGender.female,EnumDayOfWeek.Monday,new TimeSpan(20,30,0),45,EnumLevel.Beginner),
               //new Lesson(EnumTypesOfFitness.Dence,2, EnumGender.female,EnumDayOfWeek.Monday,new TimeSpan(10,30,0),45,EnumLevel.Beginner),
               //new Lesson(EnumTypesOfFitness.HIIT,3, EnumGender.male,EnumDayOfWeek.Sunday,new TimeSpan(12,30,0),45,EnumLevel.Beginner)
            };
            ClientList = new List<Client>(){
              new Client("1111","meira","vurzel",EnumGender.female,"200000","khjkhkj",EnumHealthFund. Leumit),
              new Client("2222","sprinza","vurzel",EnumGender.female,"200000","khjkhkj",EnumHealthFund.Meuhedet)

            };
        }
    }
}
