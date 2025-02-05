using Gym.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.Core.Repositories
{
    public interface IClientRepository
    {
         Task<List<Client>> GetAllClientsAsync();
         Task<Client> GetSingleByTzAsync(string tz);
         Task<Client> GetSingleByIdAsync(int id);
         Task AddClientAsync(Client client);
         Task UpdateClientAsync(int id,Client client);
         Task DeleteAsync(int id);
    }
}
