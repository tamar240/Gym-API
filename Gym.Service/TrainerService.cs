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
        private readonly IRepositoryManager _managerRepository;
        public TrainerService(ITrainerRepository trainerRepository, IRepositoryManager managerRepository)
        {
            _trainerRepository = trainerRepository;
            _managerRepository = managerRepository;
        }

        public List<Trainer> GetAllTrainers()
        {
            return _trainerRepository.GetAllTrainers();

        }

        public Trainer GetById(int id)
        {
            return _trainerRepository.GetById(id);
        }
        public Trainer GetByTz(string tz)
        {
            return _trainerRepository.GetByTz(tz);
        }
        public void AddTrainer(Trainer trainer)
        {
            _trainerRepository.AddTrainer(trainer);
            _managerRepository.Save();
        }

        public void UpdateTainer(int id,Trainer trainer)
        {
            _trainerRepository.UpdateTainer(id,trainer);
            _managerRepository.Save();
        }
        public void UpdateActive(int id, bool isActiveTrainer)
        {
            _trainerRepository.UpdateActive(id, isActiveTrainer);
            _managerRepository.Save();
        }

        public void DeleteTrainer(int id)
        {
            _trainerRepository.DeleteTrainer(id);
            _managerRepository.Save();
        }
    }
}
