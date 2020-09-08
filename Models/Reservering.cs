using System;
using System.Collections.Generic;

#nullable disable

namespace ElBiblioteka.Models
{
    public partial class Reservering
    {
        public int Id { get; set; }
        public DateTime OprettelseDato { get; set; }
        public DateTime InteresseDato { get; set; }
        public bool? ErAnnulleret { get; set; }
        public int KontoId { get; set; }
        public int MedieId { get; set; }

        public virtual BrugerKonto Konto { get; set; }
        public virtual Medie Medie { get; set; }
    }
}
