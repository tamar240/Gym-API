using Gym.Core.Entities;
using Gym.Core.Interface;
using Gym.Core.Repositories;
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
            return _context.TrainerList.ToList();
        }
       
        public Trainer GetById(string tz)
        {
            return _context.TrainerList.Where(t => t.Tz == tz).First();
        }

        public void AddTrainer(string id, string FirstName, string LastName, EnumGender Gender, string Phon, string Mail, EnumTypesOfFitness TypeOfFitness)
        {
            _context.TrainerList.Add(new Trainer(id, FirstName, LastName, Gender, Phon, Mail, TypeOfFitness));
        }

        public void UpdateTainer(string tz, string FirstName, string LastName, string Phon, string Mail, EnumTypesOfFitness TypeOfFitness)
        {
            Trainer trainer = _context.TrainerList.SingleOrDefault(t => t.Tz == tz);
            if (trainer != null)
            {
                trainer.FirstName = FirstName;
                trainer.LastName = LastName;
                trainer.Phon = Phon;
                trainer.Mail = Mail;
                trainer.TypeOfFitness = TypeOfFitness;
            }
            //else
            //    NotFound("this trainer isnt exist");
        }
        public void UpdateActive(string tz, bool isActiveTrainer)
        {
            Trainer trainer = _context.TrainerList.SingleOrDefault(t => t.Tz == tz);
            if ( trainer != null ) 
                trainer.IsActiveTrainer = isActiveTrainer;
        }
     
        public void DeleteTrainer(string tz)
        {
            _context.TrainerList.Remove(_context.TrainerList.SingleOrDefault(trainer => trainer.Tz == tz));
        }
    }
}
