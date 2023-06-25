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
    public class ChildrenService : IChildrenService
    {

        IChildrenRepository rep;
        IDataSource dataSource;
        public ChildrenService(IChildrenRepository rep, IDataSource dataSource)
        {
            this.rep = rep;
            this.dataSource = dataSource;
        }
        IMapper mapper;
        public ChildrenModel Add(ChildrenModel model)
        {
            /*var dalImage = mapper.Map<Image>(model);
            var dalImg = ctx.Image.Add(dalImage);
            ctx.SaveChanges();
            return mapper.Map<ImageModel>(dalImg);*/
            var childrens = mapper.Map<Children>(model);
            var ch = dataSource.Childrens.Add(childrens);
            dataSource.SaveChanges();
            return mapper.Map<ChildrenModel>(ch);
        }

        public void Delete(string id)
        {
            throw new NotImplementedException();
        }

        public List<ChildrenModel> GetAll()
        {
            List<Children> list = rep.GetAll();
            List<ChildrenModel> result = new List<ChildrenModel>();
            foreach (var item in list)
            {
                result.Add(mapper.Map<ChildrenModel>(item));
            }
            return result;
        }

        public ChildrenModel GetById(string id)
        {
            List<Children> list = rep.GetAll();
            Children requestedChild = list.Find(item=> item.Id == id); 
            return mapper.Map<ChildrenModel>(requestedChild);
        }

        public void Update(ChildrenModel model)
        {
            List<Children> list = rep.GetAll();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Id == model.Id)
                    list[i] = mapper.Map<Children>(model);
            }
        }
    }
}
