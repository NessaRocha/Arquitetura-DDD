using Microsoft.EntityFrameworkCore;
using Api.Domain.Entities;

namespace Api.Data.Context
{
    public class MyContext : DbContext

    {
        public DbSet<UserEntity> Users { get; set; }

        public MyContext (DbContextOptions<MyContext>options):base(options){}


    }
}