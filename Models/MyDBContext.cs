using Microsoft.EntityFrameworkCore;

namespace ERPSystem.Models
{
    public class MyDBContext:DbContext
    {
        public MyDBContext(DbContextOptions opt):base(opt){}
        
        public DbSet<General>  Generals { get; set; }
    }
}
