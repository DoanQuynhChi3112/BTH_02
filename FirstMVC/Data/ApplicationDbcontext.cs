using FirstMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace FirstMVC.Data{
    public class ApplicationDbcontext : DbContext{
        public ApplicationDbcontext()
        {
            
        }
        public ApplicationDbcontext(DbContextOptions<ApplicationDbcontext> options) : base(options)
        {}
    
        public DbSet<Customer> Customer { get; set;}
        
    }
}