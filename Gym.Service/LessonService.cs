
using Gym.Core.Entities;
using Gym.Core.Repositories;
using Gym.Core.Services;

namespace Gym.Service
{
    public class LessonService:ILessonService
    {
        private readonly ILessonRepository _lessonRepository;
        public LessonService(ILessonRepository lessonRepository)
        {
            _lessonRepository = lessonRepository;
        }
        public List<Lesson> GetAllLesson()
        {
            return _lessonRepository.GetAllLesson();
        }
        public List<Lesson> GetByDay(EnumDayOfWeek day)
        {
            return _lessonRepository.GetByDay(day);
        }
        public List<Lesson> GetByDayAndType(EnumDayOfWeek day, EnumTypesOfFitness typesOfFitness)
        {
            return _lessonRepository.GetByDayAndType(day, typesOfFitness);
        }

        public void Update(int code, EnumTypesOfFitness type, string trainerId, EnumGender targetAudience, EnumDayOfWeek day, TimeSpan start, int during, EnumLevel level)
        {

            _lessonRepository.Update(code,type, trainerId, targetAudience, day, start, during, level);
        }


        public void AddLesson( EnumTypesOfFitness type, string trainerId, EnumGender targetAudience, EnumDayOfWeek day, TimeSpan start, int during, EnumLevel level)
        {
            _lessonRepository.AddLesson( type, trainerId, targetAudience, day, start, during, level);
        }

        public void DeleteLesson(int code)
        {
            _lessonRepository.DeleteLesson(code);
        }
        

    }
}

