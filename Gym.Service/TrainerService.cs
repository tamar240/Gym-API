using Gym.Core.Entities;
using Gym.Core.Repositories;
using Gym.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Gym.Service
{
    public class TrainerService:ITrainerService
    {
        private readonly ITrainerRepository _trainerRepository;
        public TrainerService(ITrainerRepository trainerRepository)
        {
            _trainerRepository = trainerRepository;
        }

        public List<Trainer> GetAllTrainers()
        {
            return _trainerRepository.GetAllTrainers();
        }

        public Trainer GetById(string id)
        {
            return _trainerRepository.GetById(id);
        }

        public void AddTrainer(string id, string FirstName, string LastName, EnumGender Gender, string Phon, string Mail, EnumTypesOfFitness TypeOfFitness)
        {
            _trainerRepository.AddTrainer(id, FirstName, LastName, Gender, Phon, Mail, TypeOfFitness);
        }

        public void UpdateTainer(string id, string FirstName, string LastName, string Phon, string Mail, EnumTypesOfFitness TypeOfFitness)
        {
            _trainerRepository.UpdateTainer(id, FirstName, LastName, Phon, Mail, TypeOfFitness);
        }
        public void UpdateActive(string id, bool isActiveTrainer)
        {
            _trainerRepository.UpdateActive(id, isActiveTrainer);
        }

        public void DeleteTrainer(string id)
        {
            _trainerRepository.DeleteTrainer(id);
        }
    }
}
