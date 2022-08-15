using Microsoft.EntityFrameworkCore;
using Models;

namespace DataAccess;

public class PokeDbContext : DbContext
{
    //Whatever set up dbcontext does in its empty constructor, I also want to do that
    public PokeDbContext() : base() { }

    public PokeDbContext(DbContextOptions options) : base(options) { }

    public DbSet<Pokemon> Pokemons { get; set; }

    public DbSet<PokeTrainer> PokeTrainers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Pokemon>()
            .HasOne<PokeTrainer>()
            .WithMany()
            .HasForeignKey(p => p.TrainerId);
    }
}