using System;
using System.Collections.Generic;

#nullable disable

namespace ElBiblioteka.Models
{
    public partial class MedieEmner
    {
        public int Id { get; set; }
        public int EmneId { get; set; }
        public int MedieId { get; set; }

        public virtual Emner Emne { get; set; }
        public virtual Medie Medie { get; set; }
    }
}
