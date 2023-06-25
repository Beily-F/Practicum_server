using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Services.Models
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
    public class PersonalDetailModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Id { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public Gender Gender { get; set; }
        public HMO HMO { get; set; }
        public List<ChildrenModel> Childrens { get; set; }

        public PersonalDetailModel()
        {

        }
        public PersonalDetailModel(string firstName, string lastName, string id, DateOnly dateOfBirth, Gender gender, HMO hMO, List<ChildrenModel> childrens)
        {
            FirstName = firstName;
            LastName = lastName;
            Id = id;
            DateOfBirth = dateOfBirth;
            Gender = gender;
            HMO = hMO;
            Childrens = childrens;
        }

    }
}
