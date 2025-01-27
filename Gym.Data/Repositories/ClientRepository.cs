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

    public class ClientRepository :  IClientRepository
    {
        private readonly DataContext _context;
        public ClientRepository(DataContext context)
        {
            _context = context;
        }
        public List<Client> GetAllClients()
        {
            return _context.ClientList.Include(c=>c.ClientLessons).ToList();
        }
        public Client GetSingleByTz(string tz)
        {
            foreach (var client in _context.ClientList)
            {
                if (client.Tz == tz)
                    return client;
            }
            throw new KeyNotFoundException($"client with id {tz} was not found.");
        }
        public Client GetSingleById(int id)
        {
            foreach (var client in _context.ClientList)
            {
                if (client.ID == id)
                    return client;
            }
            throw new KeyNotFoundException($"client with id {id} was not found.");
        }


        public void AddClient(Client client)
        {
            _context.ClientList.Add(client);
        }

        //public void AddLessonToClient(int idClient,int idLesson)
        //    var client = _context.ClientList.Include(c => c.ClientLessons).FirstOrDefault(c => c.ID == clientId);
        //    _context.ClientList(new Client(tz, firstName, lastName, gender, phon, mail, healthFund));
        //}
        //
        public void UpdateClient(int id,Client client)
        {
            Client thisClient = _context.ClientList.SingleOrDefault(c => c.ID == id);
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

        public void Delete(int id)
        {
            var client = _context.ClientList.SingleOrDefault(c => c.ID == id);
            if(client!=null)
               _context.ClientList.Remove(client);
        }
    }
}
