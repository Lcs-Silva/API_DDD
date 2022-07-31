using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace WebApi.Data.Context
{
    public class ContextFactory : IDesignTimeDbContextFactory<MyContext>
    {
        public MyContext CreateDbContext(string[] args)
        {
            var connectionString = "Server=localhost; Port=3306; Database=webapi; Uid=root; pwd=mudar@123";
            var optionsBuilder = new DbContextOptionsBuilder<MyContext>();
            optionsBuilder.UseMySql(connectionString);
            return new MyContext(optionsBuilder.Options);
        }
    }
}