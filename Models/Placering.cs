using System;
using System.Collections.Generic;

#nullable disable

namespace ElBiblioteka.Models
{
    public partial class Placering
    {
        public Placering()
        {
            Medice = new HashSet<Medie>();
        }

        public int Id { get; set; }
        public string Dk5 { get; set; }
        public int FysiskPlaceringId { get; set; }

        public virtual FysiskPlacering FysiskPlacering { get; set; }
        public virtual ICollection<Medie> Medice { get; set; }
    }
}
