using System;
using System.Collections.Generic;

#nullable disable

namespace ElBiblioteka.Models
{
    public partial class Indhold
    {
        public Indhold()
        {
            HarIndholds = new HashSet<HarIndhold>();
        }

        public int Id { get; set; }
        public string Beskrivelse { get; set; }

        public virtual ICollection<HarIndhold> HarIndholds { get; set; }
    }
}
