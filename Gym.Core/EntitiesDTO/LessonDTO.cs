using Gym.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.Core.EntitiesDTO
{
    public class LessonDTO
    {
        public EnumTypesOfFitness Type { get; set; }
        public int TrainerID { get; set; }
        public EnumGender TargetAudience { get; set; }
        public EnumDayOfWeek Day { get; set; }
        public TimeSpan Start { get; set; }
        public int During { get; set; }//in minutes
        public EnumLevel Level { get; set; }
    }
}
