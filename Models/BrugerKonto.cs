using System;
using System.Collections.Generic;

#nullable disable

namespace ElBiblioteka.Models
{
    public partial class BrugerKonto
    {
        public BrugerKonto()
        {
            MedieUds = new HashSet<MedieUd>();
            Reserverings = new HashSet<Reservering>();
        }

        public int Id { get; set; }
        public int Login { get; set; }
        public string Password { get; set; }
        public DateTime Created { get; set; }
        public byte[] Modified { get; set; }
        public int BrugerTypeId { get; set; }
        public int BrugerId { get; set; }

        public virtual Bruger Bruger { get; set; }
        public virtual BrugerType BrugerType { get; set; }
        public virtual ICollection<MedieUd> MedieUds { get; set; }
        public virtual ICollection<Reservering> Reserverings { get; set; }
    }
}
