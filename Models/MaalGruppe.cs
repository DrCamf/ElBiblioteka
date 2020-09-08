using System;
using System.Collections.Generic;

#nullable disable

namespace ElBiblioteka.Models
{
    public partial class MaalGruppe
    {
        public MaalGruppe()
        {
            Medice = new HashSet<Medie>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Medie> Medice { get; set; }
    }
}
