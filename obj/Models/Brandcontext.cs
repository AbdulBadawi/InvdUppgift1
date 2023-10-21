using Microsoft.EntityFrameworkCore;

public class Brandcontext : DbContext
{

    public Brandcontext(DbcontextOptions<Brandcontext> options) : base(options)
    {
        
    }

   public Dbset<Brand> brands { get; set; } 
}