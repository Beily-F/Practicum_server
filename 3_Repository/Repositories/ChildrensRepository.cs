using _3_Repository.Entities;
using _3_Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Repository.Repositories
{
    public class ChildrensRepository : IChildrenRepository
    {
        IDataSource dataSource;
        public Children Add(Children model)
        {
            dataSource.Childrens.Add(model);
            return model;
        }

        public void Delete(Children model)
        {
            List<Children> childrensList = dataSource.Childrens.ToList();
            for (int i = 0; i < childrensList.Count; i++)
            {
                if (childrensList[i].Id == model.Id)
                    dataSource.Childrens.Remove(childrensList[i]);
            }
        }

        public List<Children> GetAll()
        {
            return dataSource.Childrens.ToList();
        }

        public Children GetById(string id)
        {
            List<Children> childrensList = dataSource.Childrens.ToList();
            Children children = new();
            for (int i = 0; i < childrensList.Count; i++)
            {
                if (childrensList[i].Id == id)
                    children = childrensList[i];
            }
            return children;
        }

        public void Update(Children model)
        {
            List<Children> childrensList = dataSource.Childrens.ToList();
            for (int i = 0; i < childrensList.Count; i++)
            {
                if (childrensList[i].Id == model.Id)
                {
                    childrensList[i].FirstName = model.FirstName;
                    childrensList[i].LastName = model.LastName;
                    childrensList[i].PersonalDetails = model.PersonalDetails;
                    childrensList[i].PersonalDetailsId = model.PersonalDetailsId;
                }
            }
        }
    }
}
