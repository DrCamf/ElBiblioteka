using System;
using System.Collections.Generic;

#nullable disable

namespace ElBiblioteka.Models
{
    public partial class Forfatter
    {
        public Forfatter()
        {
            ForfatterUdgivelsers = new HashSet<ForfatterUdgivelser>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<ForfatterUdgivelser> ForfatterUdgivelsers { get; set; }
    }
}
