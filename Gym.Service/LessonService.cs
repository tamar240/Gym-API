
using Gym.Core.Entities;
using Gym.Core.Repositories;
using Gym.Core.Services;

namespace Gym.Service
{
    public class LessonService:ILessonService
    {
        private readonly ILessonRepository _lessonRepository;
        private readonly IRepositoryManager _managerRepository;
        public LessonService(ILessonRepository lessonRepository, IRepositoryManager managerRepository)
        {
            _lessonRepository = lessonRepository;
            _managerRepository = managerRepository;
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

        public void Update(int code,Lesson lesson)
        {

            _lessonRepository.Update(code,lesson);
            _managerRepository.Save();
        }


        public void AddLesson( Lesson lesson)
        {
            _lessonRepository.AddLesson( lesson);
            _managerRepository.Save();
        }

        public void DeleteLesson(int code)
        {
            _lessonRepository.DeleteLesson(code);
            _managerRepository.Save();
        }
        

    }
}

