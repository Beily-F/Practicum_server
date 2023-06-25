using _3_Repository.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Repository.Interfaces
{
    public interface IDataSource
    {
        int SaveChanges();
        DbSet<Children> Childrens { get; }
        DbSet<PersonalDetails> PersonalDetails { get; }
        
    }
}
