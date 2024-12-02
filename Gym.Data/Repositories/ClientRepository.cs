using Gym.Core.Entities;
using Gym.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.Data.Repositories
{
    
    public class ClientRepository:IClientRepository
    {
        private readonly DataContext _context;
        public ClientRepository(DataContext context)
        {
            _context = context;
        }
        public List<Client> GetAllClients()
        {
            return _context.ClientList;
        }
        public Client GetSingle(string id)
        {
            foreach (var client in _context.ClientList)
            {
                if (client.Id == id)
                    return client;
            }
            throw new KeyNotFoundException($"client with id {id} was not found.");
        }


        public void AddClient(string id, string firstName, string lastName, EnumGender gender, string phon, string mail, EnumHealthFund healthFund)
        {
            _context.ClientList.Add(new Client(id, firstName, lastName, gender, phon, mail, healthFund));
        }

        public void UpdateClient(string id, string firstName, string lastName, string phon, string mail, EnumHealthFund healthFund)
        {
            Client client = _context.ClientList.SingleOrDefault(c => c.Id == id);
            if (client != null)
            {
                client.FirstName = firstName;
                client.LastName = lastName;
                client.Phon = phon;
                client.Mail = mail;
                client.HealthFund = healthFund;
            }
            else
                throw new KeyNotFoundException($"this client is not exists");

        }


        public void Delete(string id)
        {
            _context.ClientList.Remove(_context.ClientList.SingleOrDefault(c => c.Id == id));
        }
    }
}
