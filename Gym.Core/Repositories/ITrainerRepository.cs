using Gym.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.Core.Repositories
{
     public interface ITrainerRepository
    {
        public List<Trainer> GetAllTrainers();
        public Trainer GetByTz(string tz);
        public Trainer GetById(int id);

        public void AddTrainer(Trainer trainer);
        public void UpdateTainer(int id, Trainer trainer);

        public void UpdateActive(int id, bool isActiveTrainer);

        public void DeleteTrainer(int id);
    }
}
