using System;
using System.Collections.Generic;

#nullable disable

namespace ElBiblioteka.Models
{
    public partial class HarGenre
    {
        public int Id { get; set; }
        public int GenreId { get; set; }
        public int MedieId { get; set; }

        public virtual Genre Genre { get; set; }
        public virtual Medie Medie { get; set; }
    }
}
