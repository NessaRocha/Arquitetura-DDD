
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;

namespace Api.Data.Context
{
    public interface IContextFactory
    {
        MyContext CreateDbContext(string[] args);
    }

    public class ContextFactory : IDesignTimeDbContextFactory<MyContext>
    {
        public MyContext CreateDbContext(string[] args)
        {
            var connectionString = "Server=localhost;Port=3306;Database=dbAPI;Uid=root;Pwd=novasenha123";
            var optionsBuilder = new DbContextOptionsBuilder<MyContext>();
            var options = optionsBuilder.UseMySql(connectionString).Options;
            return new MyContext(optionsBuilder.Options);
        }
    }
}