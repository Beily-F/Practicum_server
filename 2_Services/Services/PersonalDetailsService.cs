using _2_Services.Interfaces;
using _2_Services.Models;
using _3_Repository.Entities;
using _3_Repository.Interfaces;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Services.Services
{
    public class PersonalDetailsService : IPersonalDetailsService
    {

        IPersonalDetailsRepository rep;
        IDataSource dataSource;
        public PersonalDetailsService()
        {

        }
        public PersonalDetailsService(IPersonalDetailsRepository rep, IDataSource dataSource)
        {
            this.rep = rep;
            this.dataSource = dataSource;
        }

       // MapperConfiguration config = new MapperConfiguration(
       //conf => conf.CreateMap<PersonalDetails, PersonalDetailModel>()
       //.ReverseMap()
       //);

        IMapper mapper;
        public PersonalDetailModel Add(PersonalDetailModel model)
        {
            var repPersonalDetails = mapper.Map<PersonalDetails>(model);
            var repPD = dataSource.PersonalDetails.Add(repPersonalDetails);
            dataSource.SaveChanges();
            return mapper.Map<PersonalDetailModel>(repPD);
        }

        public void Delete(string id)
        {
            throw new NotImplementedException();
        }

        public List<PersonalDetailModel> GetAll()
        {
            List<PersonalDetails> list = rep.GetAll();
            List<PersonalDetailModel> result = new List<PersonalDetailModel>();
            foreach (var item in list)
            {
                result.Add(mapper.Map<PersonalDetailModel>(item));
            }
            return result;
        }

        public PersonalDetailModel GetById(string id)
        {
            List<PersonalDetails> list = rep.GetAll();
            PersonalDetails requestedItem = list.Find(item => item.Id == id);
            return mapper.Map<PersonalDetailModel>(requestedItem);
        }

        public void Update(PersonalDetailModel model)
        {
            List<PersonalDetails> list = rep.GetAll();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Id == model.Id)
                    list[i] = mapper.Map<PersonalDetails>(model);
            }
        }
    }
}
