using System;
using System.Collections.Generic;

#nullable disable

namespace ElBiblioteka.Models
{
    public partial class HarFormat
    {
        public int Id { get; set; }
        public int FormatId { get; set; }
        public int MedieId { get; set; }

        public virtual Format Format { get; set; }
        public virtual Medie Medie { get; set; }
    }
}
