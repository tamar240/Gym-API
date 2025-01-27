using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices.Marshalling;
using System.Text.Json;

namespace Gym.Core.Entities
{
    public enum EnumDayOfWeek { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday }
    public class Lesson
    {
        //private static int count = 0;
        [Key]
        public int ID { get; set; }
        public EnumTypesOfFitness Type { get; set; }
        public int TrainerID { get; set; }

      //public Trainer trainer { get; set; }//האם יש ענין לעשות זאת?

        public EnumGender TargetAudience { get; set; }
        public EnumDayOfWeek Day { get; set; }
        public TimeSpan Start { get; set; }
        public int During { get; set; }//in minutes
        public TimeSpan End { get; set; }//
        public EnumLevel Level { get; set; }
        public List<Client> clients { get; set; }//כשמציגים שעור מסוים לא אמורים להראות מי הלקוחות שנמצאים באותו שעור
        public Lesson()
        {
        }
        public Lesson(EnumTypesOfFitness type, int trainerId, EnumGender targetAudience, EnumDayOfWeek day, TimeSpan start, int during, EnumLevel level)
        {
            Type = type;
            TrainerID = trainerId;
            TargetAudience = targetAudience;
            Day = day;
            Start = start;
            During = during;
            End = Start.Add(TimeSpan.FromMinutes(during));
            Level = level;
            this.clients = new List<Client>();

        }
   
    }
    public class TimeSpanConverter : System.Text.Json.Serialization.JsonConverter<TimeSpan>
    {
        public override TimeSpan Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return TimeSpan.Parse(reader.GetString());
        }

        public override void Write(Utf8JsonWriter writer, TimeSpan value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.ToString());
        }
    }

}
