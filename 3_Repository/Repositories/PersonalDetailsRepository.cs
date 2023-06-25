using _3_Repository.Entities;
using _3_Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Repository.Repositories
{
    public class PersonalDetailsRepository : IPersonalDetailsRepository
    {
        IDataSource dataSource;

        public PersonalDetailsRepository(IDataSource dataSource)
        {
            this.dataSource = dataSource;
        }

        public PersonalDetails Add(PersonalDetails model)
        {
            dataSource.PersonalDetails.Add(model);
            return model;
        }

        public void Delete(PersonalDetails model)
        {
            dataSource.PersonalDetails.Remove(model);
        }

        public List<PersonalDetails> GetAll()
        {
            return dataSource.PersonalDetails.ToList();
        }

        public PersonalDetails GetById(string id)
        {
            List<PersonalDetails> personalDetailsList = dataSource.PersonalDetails.ToList();
            PersonalDetails personalDetails = new();
            for (int i = 0; i < personalDetailsList.Count; i++)
                if (personalDetailsList[i].Id == id)
                    personalDetails = personalDetailsList[i];
            return personalDetails;
        }

        //public List<PersonalDetails> Search(string id)
        //{
        //    List<PersonalDetails> personalDetailsList = dataSource.PersonalDetails.ToList();
        //    for (int i = 0; i < pages.Count; i++)
        //    {
        //        if (pages[i].PageId == key)
        //        {
        //            dataSource.Pages.Remove(pages[i]);
        //            return;
        //        }
        //    }
        //}

        public void Update(PersonalDetails model)
        {
            List<PersonalDetails> personalDetailsList = dataSource.PersonalDetails.ToList();
            for (int i = 0; i < personalDetailsList.Count; i++)
            {
                if (personalDetailsList[i].Id == model.Id)
                {
                    personalDetailsList[i].FirstName = model.FirstName;
                    personalDetailsList[i].LastName = model.LastName;
                    personalDetailsList[i].DateOfBirth = model.DateOfBirth;
                    personalDetailsList[i].Gender = model.Gender;
                    personalDetailsList[i].HMO = model.HMO;
                }
            }
        }
    }
}
