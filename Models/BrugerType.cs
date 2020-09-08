using System;
using System.Collections.Generic;

#nullable disable

namespace ElBiblioteka.Models
{
    public partial class BrugerType
    {
        public BrugerType()
        {
            BrugerKontos = new HashSet<BrugerKonto>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Beskrivelse { get; set; }

        public virtual ICollection<BrugerKonto> BrugerKontos { get; set; }
    }
}
