using Gym.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.Core.EntitiesDTO
{
    public class TrainerPostDTO
    {
        public string Tz { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public EnumGender Gender { get; set; }
        public string Phon { get; set; }
        public string Mail { get; set; }
        public /*List <*/EnumTypesOfFitness/*>*/ TypeOfFitness { get; set; }
        public bool IsActiveTrainer { get; set; }
    }
}
