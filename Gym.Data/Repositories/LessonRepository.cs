using Gym.Core.Entities;
using Gym.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.Data.Repositories
{
    public class LessonRepository:ILessonRepository
    {
        private readonly DataContext _context;
        public LessonRepository(DataContext context)
        {
            _context = context;
        }
        public List<Lesson> GetAllLesson()
        {
            return _context.LessonList;
        }
        public List<Lesson> GetByDay(EnumDayOfWeek day)
        {
            return _context.LessonList.Where(l => l.Day == day).ToList();
        }
        public List<Lesson> GetByDayAndType(EnumDayOfWeek day, EnumTypesOfFitness typesOfFitness)
        {
            return _context.LessonList.Where(l => l.Day == day && l.Type == typesOfFitness).ToList();
        }

        public void AddLesson(EnumTypesOfFitness type, string trainerId, EnumGender targetAudience, EnumDayOfWeek day, TimeSpan start, int during, EnumLevel level)
        {

            _context.LessonList.Add(new Lesson(type, trainerId, targetAudience, day, start, during, level));
        }

       
        public void  Update(int code, EnumTypesOfFitness type, string trainerId, EnumGender targetAudience, EnumDayOfWeek day, TimeSpan start, int during, EnumLevel level)
        {
            Lesson lesson = _context.LessonList.SingleOrDefault(l => l.Code == code);
            if (lesson != null)
            {
                lesson.Type = type;
                lesson.TrainerId = trainerId;
                lesson.TargetAudience = targetAudience;
                lesson.Day = day;
                lesson.Start = start;
                lesson.During = during;
                lesson.Level = level;
            }
            //else
            //    NotFound("this lesson isnt exist");
        }

        public void DeleteLesson(int code)
        {
            _context.LessonList.Remove(_context.LessonList.SingleOrDefault(l => l.Code == code));
        }


    }
}

