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
        public async  Task<List<Client>> GetAll()
        {
            return  await _clientRepository.GetAllClientsAsync();
        }
       
        public async Task< Client> GetSingleByTz(string tz)
        {
            return  await _clientRepository.GetSingleByTzAsync(tz);
        }

        public async Task<Client > GetSingleById(int id)
        {
            return await _clientRepository.GetSingleByIdAsync(id);
        }
        public async Task AddClient(Client client)
        {
           _clientRepository.AddClientAsync(client);
      
            _managerRepository.Save();


        }

        public async Task UpdateClient(int id,Client client)
        {
            _clientRepository.UpdateClientAsync(id,client);
            _managerRepository.Save();
        }


        public async Task Delete(int id)
        {
            _clientRepository.DeleteAsync(id);
            _managerRepository.Save();
        }
    }
}
