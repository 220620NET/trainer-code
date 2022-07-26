using System;
using System.Collections.Generic;

namespace DataAccess.Entities
{
    public partial class Pokemon
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int Level { get; set; }
        public int TrainerId { get; set; }
        public string Type { get; set; } = null!;
        public string? NickName { get; set; }
        public string? Disposition { get; set; }

        public virtual PokeTrainer Trainer { get; set; } = null!;
    }
}
