using Gym.Core.Entities;

namespace Gym.Core.Interface
{
    public interface IDataContext
    {
        static List<Trainer> TrainerList { get; set; }
        static List<Client> ClientList { get; set; }
        static List<Lesson> LessonList { get; set; }

    }
}
