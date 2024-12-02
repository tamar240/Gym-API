using System.Runtime.InteropServices.Marshalling;
using System.Text.Json;

namespace Gym.Core.Entities
{
    public enum EnumDayOfWeek { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday }
    public class Lesson
    {
        private static int count = 0;
        public int Code { get; }
        public EnumTypesOfFitness Type { get; set; }
        public string TrainerId { get; set; }
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
            Code = ++count;
            Type = type;
            TrainerId = trainerId;
            TargetAudience = targetAudience;
            Day = day;
            Start = start;
            During = during;
            End = Start.Add(TimeSpan.FromMinutes(during));
            Level = level;
        }

    }
}
