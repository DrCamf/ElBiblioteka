using System;
using System.Collections.Generic;

#nullable disable

namespace ElBiblioteka.Models
{
    public partial class KortReferat
    {
        public KortReferat()
        {
            HarReferats = new HashSet<HarReferat>();
        }

        public int Id { get; set; }
        public string Beskrivelse { get; set; }

        public virtual ICollection<HarReferat> HarReferats { get; set; }
    }
}
