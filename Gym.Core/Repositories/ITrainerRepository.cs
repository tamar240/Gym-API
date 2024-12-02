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
        public Trainer GetById(string id);

        public void AddTrainer(string id, string FirstName, string LastName, EnumGender Gender, string Phon, string Mail, EnumTypesOfFitness TypeOfFitness);
        public void UpdateTainer(string id, string FirstName, string LastName, string Phon, string Mail, EnumTypesOfFitness TypeOfFitness);

        public void UpdateActive(string id, bool isActiveTrainer);

        public void DeleteTrainer(string id);
    }
}
