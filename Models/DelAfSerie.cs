using System;
using System.Collections.Generic;

#nullable disable

namespace ElBiblioteka.Models
{
    public partial class DelAfSerie
    {
        public int Id { get; set; }
        public int? SerieNr { get; set; }
        public int SerieId { get; set; }
        public int MedieId { get; set; }

        public virtual Medie Medie { get; set; }
        public virtual Serier Serie { get; set; }
    }
}
