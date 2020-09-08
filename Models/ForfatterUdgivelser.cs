using System;
using System.Collections.Generic;

#nullable disable

namespace ElBiblioteka.Models
{
    public partial class ForfatterUdgivelser
    {
        public int Id { get; set; }
        public int ForfatterId { get; set; }
        public int MedieId { get; set; }

        public virtual Forfatter Forfatter { get; set; }
        public virtual Medie Medie { get; set; }
    }
}
