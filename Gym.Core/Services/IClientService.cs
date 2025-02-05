using Gym.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.Core.Services
{
    public interface IClientService
    {
        Task< List<Client> >GetAll();
        Task< Client> GetSingleByTz(string tz);
        Task<Client >GetSingleById(int id);
        Task AddClient(Client client);
        Task UpdateClient(int id,Client client);
        Task Delete(int id);
    }


}
