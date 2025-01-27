using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gym.Core.Entities;

namespace Gym.Core.Services
{
    public interface ILessonService
    {
        public List<Lesson> GetAllLesson();
        public List<Lesson> GetByDay(EnumDayOfWeek day);
        public List<Lesson> GetByDayAndType(EnumDayOfWeek day, EnumTypesOfFitness typesOfFitness);
        public void Update(int code, Lesson lesson);
        public void AddLesson(Lesson lesson);
        public void DeleteLesson(int code);
    }
}
