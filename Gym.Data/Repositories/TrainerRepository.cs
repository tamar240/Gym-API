using Gym.Core.Entities;
using Gym.Core.Interface;
using Gym.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.Data.Repositories
{
    public class TrainerRepository:ITrainerRepository
    {
        private readonly DataContext _context;
        public TrainerRepository(DataContext context)
        {
            _context = context;
        }

        public List<Trainer> GetAllTrainers()
        {
            return _context.TrainerList.Include(t => t.TrainerLessons).ToList();
        }
       
        public Trainer GetByTz(string tz)
        {
            return _context.TrainerList.Where(t => t.Tz == tz).Include(t => t.TrainerLessons).FirstOrDefault();
        }
        public Trainer GetById(int id)
        {
            return _context.TrainerList.Where(t => t.ID == id).Include(t => t.TrainerLessons).FirstOrDefault();
        }

        public void AddTrainer(Trainer trainer)
        {
            _context.TrainerList.Add(trainer);
        }

        public void UpdateTainer(int id,Trainer trainer)
        {
            Trainer thisTrainer = _context.TrainerList.SingleOrDefault(t => t.ID == id);
            if (trainer != null)
            {
                thisTrainer.FirstName = trainer.FirstName;
                thisTrainer.LastName = trainer.LastName;
                thisTrainer.Phon = trainer.Phon;
                thisTrainer.Mail = trainer.Mail;
                thisTrainer.TypeOfFitness = trainer.TypeOfFitness;
            }
            //else
            //    NotFound("this trainer isnt exist");
        }
        public void UpdateActive(int id, bool isActiveTrainer)
        {
            Trainer trainer = _context.TrainerList.SingleOrDefault(t => t.ID == id);
            if ( trainer != null ) 
                trainer.IsActiveTrainer = isActiveTrainer;
        }
     
        public void DeleteTrainer(int id)
        {
            var trainer = _context.TrainerList.SingleOrDefault(trainer => trainer.ID == id);
            if (trainer != null)
               _context.TrainerList.Remove(trainer);
        }
    }
}
