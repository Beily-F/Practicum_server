using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Repository.Interfaces
{
    public interface IRepository<T>
    {
        T Add(T model);
        void Update(T model);
        void Delete(T model);
        T GetById(string id);
        List<T> GetAll();
        //List<T> Search(int id);
    }
}
