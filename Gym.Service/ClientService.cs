using Gym.Core.Entities;
using Gym.Core.Services;
using Gym.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.Service
{
    public class ClientService:IClientService
    {
        private readonly IClientRepository _clientRepository;
        private readonly IRepositoryManager _managerRepository;
        public ClientService(IClientRepository clientRepository, IRepositoryManager managerRepository)
        {
            _clientRepository = clientRepository;
            _managerRepository = managerRepository;
        }
        public List<Client> GetAll()
        {
            return _clientRepository.GetAllClients();
        }
       
        public Client GetSingleByTz(string tz)
        {
            return _clientRepository.GetSingleByTz(tz);
        }

        public Client GetSingleById(int id)
        {
            return _clientRepository.GetSingleById(id);
        }
        public void AddClient(Client client)
        {
           _clientRepository.AddClient(client);
      
            _managerRepository.Save();


        }

        public void UpdateClient(int id,Client client)
        {
            _clientRepository.UpdateClient(id,client);
            _managerRepository.Save();
        }


        public void Delete(int id)
        {
            _clientRepository.Delete(id);
            _managerRepository.Save();
        }
    }
}
