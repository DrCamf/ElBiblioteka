using System;
using System.Collections.Generic;

#nullable disable

namespace ElBiblioteka.Models
{
    public partial class Serier
    {
        public Serier()
        {
            DelAfSeries = new HashSet<DelAfSerie>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<DelAfSerie> DelAfSeries { get; set; }
    }
}
