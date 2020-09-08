using System;
using System.Collections.Generic;

#nullable disable

namespace ElBiblioteka.Models
{
    public partial class HarIndhold
    {
        public int Id { get; set; }
        public int IndholdId { get; set; }
        public int MedieId { get; set; }

        public virtual Indhold Indhold { get; set; }
        public virtual Medie Medie { get; set; }
    }
}
