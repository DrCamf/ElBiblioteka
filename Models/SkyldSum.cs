using System;
using System.Collections.Generic;

#nullable disable

namespace ElBiblioteka.Models
{
    public partial class SkyldSum
    {
        public SkyldSum()
        {
            Skylds = new HashSet<Skyld>();
        }

        public int Id { get; set; }
        public int Sum { get; set; }
        public string Beskrivelse { get; set; }

        public virtual ICollection<Skyld> Skylds { get; set; }
    }
}
