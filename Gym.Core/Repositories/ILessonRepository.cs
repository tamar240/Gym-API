using Gym.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.Core.Repositories
{
    public interface ILessonRepository
    {
        public List<Lesson> GetAllLesson();
        public List<Lesson> GetByDay(EnumDayOfWeek day);
        public List<Lesson> GetByDayAndType(EnumDayOfWeek day, EnumTypesOfFitness typesOfFitness);
        public void Update(int code,EnumTypesOfFitness type, string trainerId, EnumGender targetAudience, EnumDayOfWeek day, TimeSpan start, int during, EnumLevel level);
        public void AddLesson(EnumTypesOfFitness type, string trainerId, EnumGender targetAudience, EnumDayOfWeek day, TimeSpan start, int during, EnumLevel level);
        public void DeleteLesson(int id);
        

    }
}
