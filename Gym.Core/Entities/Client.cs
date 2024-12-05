using System.Collections;
using System.ComponentModel.DataAnnotations;

namespace Gym.Core.Entities
{
    public enum EnumHealthFund { Clalit, Maccabi, Meuhedet, Leumit }
    public class Client
    {
        //private static int count = 0;
        [Key]
        public int ID { get; set; }
        public string Tz { get; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public EnumGender Gender { get; set; }
        public string Phon { get; set; }
        public string Mail { get; set; }
        public EnumHealthFund HealthFund { get; set; }
        public bool IsActiveClient { get; set; }
        public List<Lesson> ClientLessons { get; set; }
        public Client()
        { }
        public Client(string id, string firstName, string lastName, EnumGender gender, string phon, string mail, EnumHealthFund healthFund)
        {
            //ID = ++count;
            Tz = id;
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
            Phon = phon;
            Mail = mail;
            HealthFund = healthFund;
            IsActiveClient = true;
        }
    }
}
