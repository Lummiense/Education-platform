using api.Entities;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace api
{
    public class DataContext:DbContext
    {
        public DbSet<UserEntity> Users { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
           
        }
    }
}