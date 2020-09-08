using System;
using System.Collections.Generic;

#nullable disable

namespace ElBiblioteka.Models
{
    public partial class Genre
    {
        public Genre()
        {
            HarGenres = new HashSet<HarGenre>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<HarGenre> HarGenres { get; set; }
    }
}
