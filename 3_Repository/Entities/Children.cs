using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Repository.Entities
{
    public class Children
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Id { get; set; }
        public PersonalDetails PersonalDetails { get; set; }
        public string PersonalDetailsId { get; set; }
        //public static int ChildrenCount { get; set; }

        public Children()
        {

        }
        public Children(string firstName,string lastName,string id,PersonalDetails personalDetails, string personalDetailsId)
        {
            FirstName = firstName;
            LastName = lastName;
            Id = id;
            PersonalDetails = personalDetails;
            PersonalDetailsId = personalDetailsId;

        }
    }
}
