using FullStack.API.Models;
using Microsoft.EntityFrameworkCore;

namespace FullStack.API.Data
{
    public class FullStackDBContext:DbContext
    {
        public FullStackDBContext(DbContextOptions options) : base(options) 
        { 
        
        }

        public DbSet<Employee> Employees { get; set; }

    }
}
