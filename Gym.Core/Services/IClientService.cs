﻿using Gym.Core.Entities;
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
        public Client GetSingle(string id);
        public void AddClient(string id, string firstName, string lastName, EnumGender gender, string phon, string mail, EnumHealthFund healthFund);
        public void UpdateClient(string id, string firstName, string lastName, string phon, string mail, EnumHealthFund healthFund);
        public void Delete(string id);

    }


}