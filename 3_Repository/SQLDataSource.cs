using _3_Repository.Entities;
using _3_Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace _3_Repository
{
    public class SQLDataSource:DbContext,IDataSource
    {
        public DbSet<Children> Childrens => throw new NotImplementedException();

        public DbSet<PersonalDetails> PersonalDetails => throw new NotImplementedException();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@";TrustServerCertificate=True");
            base.OnConfiguring(optionsBuilder);
        }
    }
}