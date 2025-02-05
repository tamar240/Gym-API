using Gym.Core.Entities;
using Gym.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.Data.Repositories
{

    public class ClientRepository : IClientRepository
    {
        private readonly DataContext _context;
        public ClientRepository(DataContext context)
        {
            _context = context;
        }
        public async Task<List<Client>> GetAllClientsAsync()
        {
            return await _context.ClientList.Include(c => c.ClientLessons).ToListAsync();
        }
        public async Task<Client> GetSingleByTzAsync(string tz)
        {
            var client = await _context.ClientList.FirstOrDefaultAsync(c => c.Tz == tz);

            if (client == null)
                throw new KeyNotFoundException($"Client with tz {tz} was not found.");

            return client;
        }

        public async Task<Client> GetSingleByIdAsync(int id)
        {
            var client = await _context.ClientList.FirstOrDefaultAsync(c => c.ID == id);

            if (client == null)
            throw new KeyNotFoundException($"Client with id {id} was not found.");

            return client;
        }


        public async Task AddClientAsync(Client client)
        {
            await _context.ClientList.AddAsync(client);
        }

        //public void AddLessonToClient(int idClient,int idLesson)
        //    var client = _context.ClientList.Include(c => c.ClientLessons).FirstOrDefault(c => c.ID == clientId);
        //    _context.ClientList(new Client(tz, firstName, lastName, gender, phon, mail, healthFund));
        //}
        //
        public async Task UpdateClientAsync(int id,Client client)
        {
            var thisClient =await _context.ClientList.SingleOrDefaultAsync(c => c.ID == id);
            if (client != null)
            {
                thisClient.FirstName = client.FirstName;
                thisClient.LastName = client.LastName;
                thisClient.Phon = client.Phon;
                thisClient.Mail = client.Mail;
                thisClient.HealthFund = client.HealthFund;
            }
            else
                throw new KeyNotFoundException($"this client is not exists");

        }

        public async Task DeleteAsync(int id)
        {
            var client =await _context.ClientList.SingleOrDefaultAsync(c => c.ID == id);
            if(client!=null)
               _context.ClientList.Remove(client);
        }


    }
}
