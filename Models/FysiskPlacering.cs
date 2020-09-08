using System;
using System.Collections.Generic;

#nullable disable

namespace ElBiblioteka.Models
{
    public partial class FysiskPlacering
    {
        public FysiskPlacering()
        {
            Placerings = new HashSet<Placering>();
        }

        public int Id { get; set; }
        public string Sted { get; set; }

        public virtual ICollection<Placering> Placerings { get; set; }
    }
}
