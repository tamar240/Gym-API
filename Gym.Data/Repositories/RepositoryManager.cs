using Gym.Core.Repositories;
using Gym.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class RepositoryManager : IRepositoryManager
{
    private readonly DataContext _context;
    //public IClientRepository Clients { get; }
    //public ILessonRepository Lessons { get; }
    //public ITrainerRepository Trainers { get; }

    public RepositoryManager(DataContext context/*, IClientRepository clientRepository, ILessonRepository lessonRepository, ITrainerRepository trainerRepository*/)
    {
        _context = context;
        //Clients = clientRepository;
        //Lessons = lessonRepository;
        //Trainers = trainerRepository;
    }

    public void Save()
    {
        _context.SaveChanges();
    }
}