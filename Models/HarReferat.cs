using System;
using System.Collections.Generic;

#nullable disable

namespace ElBiblioteka.Models
{
    public partial class HarReferat
    {
        public int Id { get; set; }
        public int ReferatId { get; set; }
        public int MedieId { get; set; }

        public virtual Medie Medie { get; set; }
        public virtual KortReferat Referat { get; set; }
    }
}
