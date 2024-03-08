using Microsoft.EntityFrameworkCore;
namespace IFCE.Chaves.Infra.Data.Context;
 
public class AppContext : DbContext
{
    public AppContext() { }
    
    public AppContext(DbContextOptions<AppContext> options) : base(options) { }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var connect = "";
        optionsBuilder.UseMySql(connect, ServerVersion.AutoDetect(connect));
        optionsBuilder.EnableDetailedErrors();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        
    }
    
    public async Task<bool> Commit() => await SaveChangesAsync() > 0;

}