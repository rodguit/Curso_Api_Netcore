using System.Net.Security;
using System.Reflection;
using Api.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Api.Data
{
    public class ContextFactory : IDesignTimeDbContextFactory<MyContext>
    {
        public MyContext CreateDbContext(string[] args)
        {
            var connectionString = "Server=localhost;Port=3306;Database=dbAPI;Uid=root;Pwd=caovino288";
            var optionsBuilder = new DbContextOptionsBuilder<MyContext> ();
            optionsBuilder.UseMySql (connectionString);
            return new MyContext (optionsBuilder.Options);
        }

    }
}
