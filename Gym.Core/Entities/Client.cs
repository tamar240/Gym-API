using System.Collections;

namespace Gym.Core.Entities
{
    public enum EnumHealthFund { Clalit, Maccabi, Meuhedet, Leumit }
    public class Client
    {
        private static int count = 0;
        public int Code { get; }
        public string Id { get; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public EnumGender Gender { get; set; }
        public string Phon { get; set; }
        public string Mail { get; set; }
        public EnumHealthFund HealthFund { get; set; }
        public bool IsActiveClient { get; set; }
        public List<Lesson> ClientLessons { get; set; }

        public Client(string id, string firstName, string lastName, EnumGender gender, string phon, string mail, EnumHealthFund healthFund)
        {
            Code = ++count;
            Id = id;
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
