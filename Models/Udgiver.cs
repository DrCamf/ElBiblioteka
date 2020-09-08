using System;
using System.Collections.Generic;

#nullable disable

namespace ElBiblioteka.Models
{
    public partial class Udgiver
    {
        public Udgiver()
        {
            Medice = new HashSet<Medie>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int? TlfNr { get; set; }
        public string Adresse { get; set; }
        public string PostnrId { get; set; }

        public virtual Postnr Postnr { get; set; }
        public virtual ICollection<Medie> Medice { get; set; }
    }
}
