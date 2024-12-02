using System.Collections;

namespace Gym.Core.Entities
{
    public enum EnumGender { male, female }
    public enum EnumTypesOfFitness { Pilates, HIIT, Aerobics, Dence, FloorExercise }
    public enum EnumLevel { Beginner, advanced }
    public class Trainer
    {
        private static int count = 0;
        public int Code { get; }
        public string Id { get; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public EnumGender Gender { get; set; }
        public string Phon { get; set; }
        public string Mail { get; set; }
        public /*List <*/EnumTypesOfFitness/*>*/ TypeOfFitness { get; set; }
        public bool IsActiveTrainer { get; set; }
        public List<Lesson> TrainerLessons { get; set; }


        public Trainer(string id, string firstName, string lastName, EnumGender gender, string phon, string mail,/*List <*/EnumTypesOfFitness/*>*/ typesOfFitness)
        {
            Code = ++count;
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
            Phon = phon;
            Mail = mail;
            TypeOfFitness = typesOfFitness;
            IsActiveTrainer = true;
            TrainerLessons = new List<Lesson>();
        }

    }
}
