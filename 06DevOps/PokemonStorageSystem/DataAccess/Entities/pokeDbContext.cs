using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DataAccess.Entities
{
    public partial class pokeDbContext : DbContext
    {
        public pokeDbContext()
        {
        }

        public pokeDbContext(DbContextOptions<pokeDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<PokeTrainer> PokeTrainers { get; set; } = null!;
        public virtual DbSet<Pokemon> Pokemons { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PokeTrainer>(entity =>
            {
                entity.Property(e => e.Money).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<Pokemon>(entity =>
            {
                entity.HasIndex(e => e.TrainerId, "IX_Pokemons_TrainerId");

                entity.HasOne(d => d.Trainer)
                    .WithMany(p => p.Pokemons)
                    .HasForeignKey(d => d.TrainerId);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
