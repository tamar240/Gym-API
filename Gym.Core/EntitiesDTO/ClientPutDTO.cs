using Gym.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.Core.EntitiesDTO
{
  
    public class ClientPutDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phon { get; set; }
        public string Mail { get; set; }
        public EnumHealthFund HealthFund { get; set; }
    }
}
