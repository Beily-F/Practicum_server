using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Repository.Entities
{
    public enum Gender
    {
        MALE,
        FEMALE
    }
    public enum HMO
    {
        MEUHEDET,
        MACABI,
        KLALIT,
        LEUMIT
    }
    public class PersonalDetails
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Id { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public Gender Gender { get; set; }
        public HMO HMO { get; set; }
        public List<Children> Childrens { get; set; }

        public PersonalDetails(string firstName, string lastName, string id, DateOnly dateOfBirth, Gender gender, HMO hMO, List<Children> childrens)
        {
            FirstName = firstName;
            LastName = lastName;
            Id = id;
            DateOfBirth = dateOfBirth;
            Gender = gender;
            HMO = hMO;
            Childrens = childrens;
        }

        public PersonalDetails()
        {
        }
    }
}
