using System.Collections;
using System.ComponentModel.DataAnnotations;

namespace Gym.Core.Entities
{
    public enum EnumGender { male, female }
    public enum EnumTypesOfFitness { Pilates, HIIT, Aerobics, Dence, FloorExercise }
    public enum EnumLevel { Beginner, advanced }
    public class Trainer
    {
        private static int count = 0;
        [Key]
        public int ID { get; set; }
        public string Tz { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public EnumGender Gender { get; set; }
        public string Phon { get; set; }
        public string Mail { get; set; }
        public /*List <*/EnumTypesOfFitness/*>*/ TypeOfFitness { get; set; }
        public bool IsActiveTrainer { get; set; }
        public List<Lesson> TrainerLessons { get; set; }

        public Trainer() { }
        public Trainer(string id, string firstName, string lastName, EnumGender gender, string phon, string mail,/*List <*/EnumTypesOfFitness/*>*/ typesOfFitness)
        {
            ID = ++count;
            Tz = id;
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
