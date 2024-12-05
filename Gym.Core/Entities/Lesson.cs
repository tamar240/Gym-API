using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices.Marshalling;
using System.Text.Json;

namespace Gym.Core.Entities
{
    public enum EnumDayOfWeek { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday }
    public class Lesson
    {
        private static int count = 0;
        [Key]
        public int ID { get; set; }
        public EnumTypesOfFitness Type { get; set; }
        public string TrainerID { get; set; }
        public EnumGender TargetAudience { get; set; }
        public EnumDayOfWeek Day { get; set; }
        public TimeSpan Start { get; set; }
        public int During { get; set; }//in minutes
        public TimeSpan End { get; set; }//
        public EnumLevel Level { get; set; }

        public Lesson()
        {

        }
        public Lesson(EnumTypesOfFitness type, string trainerId, EnumGender targetAudience, EnumDayOfWeek day, TimeSpan start, int during, EnumLevel level)
        {
            ID = ++count;
            Type = type;
            TrainerID = trainerId;
            TargetAudience = targetAudience;
            Day = day;
            Start = start;
            During = during;
            End = Start.Add(TimeSpan.FromMinutes(during));
            Level = level;
        }

    }
}
