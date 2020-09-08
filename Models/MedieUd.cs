using System;
using System.Collections.Generic;

#nullable disable

namespace ElBiblioteka.Models
{
    public partial class MedieUd
    {
        public MedieUd()
        {
            Skylds = new HashSet<Skyld>();
        }

        public int Id { get; set; }
        public DateTime UdDato { get; set; }
        public DateTime ForventetDato { get; set; }
        public DateTime? IndDato { get; set; }
        public int KontoId { get; set; }
        public int MedieId { get; set; }

        public virtual BrugerKonto Konto { get; set; }
        public virtual Medie Medie { get; set; }
        public virtual ICollection<Skyld> Skylds { get; set; }
    }
}
