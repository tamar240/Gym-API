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
        public ClientService(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }
        public List<Client> GetAll()
        {
            return _clientRepository.GetAllClients();
        }
       
        public Client GetSingle(string id)
        {
            return _clientRepository.GetSingle(id);
        }

      
        public void AddClient(string id, string firstName, string lastName, EnumGender gender, string phon, string mail, EnumHealthFund healthFund)
        {
           _clientRepository.AddClient(id, firstName, lastName, gender, phon, mail, healthFund);
        }

        public void UpdateClient(string id, string firstName, string lastName, string phon, string mail, EnumHealthFund healthFund)
        {
            _clientRepository.UpdateClient(id, firstName, lastName, phon, mail, healthFund);
        }


        public void Delete(string id)
        {
            _clientRepository.Delete(id);
        }
    }
}
