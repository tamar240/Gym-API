using AutoMapper;
using Gym.Core.Entities;
using Gym.Core.EntitiesDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.Core
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Client,ClientPutDTO>().ReverseMap();
            CreateMap<Client,ClientPostDTO>().ReverseMap();

            CreateMap<Lesson,LessonDTO>().ReverseMap();

            CreateMap<Trainer,TrainerPutDTO>().ReverseMap();
            CreateMap<Trainer,TrainerPostDTO>().ReverseMap();
        }
    }
}
