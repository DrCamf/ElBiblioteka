using System;
using System.Collections.Generic;

#nullable disable

namespace ElBiblioteka.Models
{
    public partial class Bruger
    {
        public Bruger()
        {
            BrugerKontos = new HashSet<BrugerKonto>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? TlfNr { get; set; }
        public string Email { get; set; }
        public string Adresse { get; set; }
        public DateTime Created { get; set; }
        public byte[] Modified { get; set; }
        public string PostnrId { get; set; }

        public virtual Postnr Postnr { get; set; }
        public virtual ICollection<BrugerKonto> BrugerKontos { get; set; }
    }
}
