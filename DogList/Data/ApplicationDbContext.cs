using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;
using DogList.Data;
using DogList.Models;

namespace DogList.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        public DbSet<Dog> Dog { get; set; }
    }
}
