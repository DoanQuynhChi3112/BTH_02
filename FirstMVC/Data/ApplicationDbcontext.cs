using FirstMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace FirstMVC.Data{
    public class ApplicationDbcontext : DbContext{
        public ApplicationDbcontext()
        {
            
        }
        public ApplicationDbcontext(DbContextOptions<ApplicationDbcontext> options) : base(options)
        {}
        public DbSet<Person> Person { get; set;}
        public DbSet<Employee> Employee { get; set;}
        
    }
}