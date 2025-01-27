using Gym.Core.Entities;
using Gym.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
            return _context.LessonList.ToList();
        }
        public List<Lesson> GetByDay(EnumDayOfWeek day)
        {
            return _context.LessonList.Where(l => l.Day == day).Include(l=>l.clients).ToList();
        }
        public List<Lesson> GetByDayAndType(EnumDayOfWeek day, EnumTypesOfFitness typesOfFitness)
        {
            return _context.LessonList.Where(l => l.Day == day && l.Type == typesOfFitness).Include(l => l.clients).ToList();
        }

        public void AddLesson(Lesson lesson)
        {

            _context.LessonList.Add( lesson);
        }


        public void Update(int id, Lesson lesson)
        {
            Lesson thisLesson = _context.LessonList.SingleOrDefault(l => l.ID == id);
            if (thisLesson != null)
            {
                thisLesson.Type = lesson.Type;
                thisLesson.TrainerID = lesson.TrainerID;
                thisLesson.TargetAudience = lesson.TargetAudience;
                thisLesson.Day = lesson.Day;
                thisLesson.Start = lesson.Start;
                thisLesson.End = lesson.Start.Add(TimeSpan.FromMinutes(lesson.During));
                thisLesson.During = lesson.During;
                thisLesson.Level = lesson.Level;
            }
        }

        public void DeleteLesson(int id)
        {
            var lesson = _context.LessonList.SingleOrDefault(l => l.ID == id);
            if (lesson != null)
              _context.LessonList.Remove(lesson);
        }


    }
}

