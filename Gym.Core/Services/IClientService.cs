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
        public List<Client> GetAll();
        public Client GetSingleByTz(string tz);
        public Client GetSingleById(int id);
        public void AddClient(Client client);
        public void UpdateClient(int id,Client client);
        public void Delete(int id);
    }


}
