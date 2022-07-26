using System;
using System.Collections.Generic;

namespace DataAccess.Entities
{
    public partial class PokeTrainer
    {
        public PokeTrainer()
        {
            Pokemons = new HashSet<Pokemon>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int NumBadges { get; set; }
        public decimal Money { get; set; }
        public DateTime DoB { get; set; }

        public virtual ICollection<Pokemon> Pokemons { get; set; }
    }
}
