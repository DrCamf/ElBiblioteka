using System;
using System.Collections.Generic;

#nullable disable

namespace ElBiblioteka.Models
{
    public partial class Postnr
    {
        public Postnr()
        {
            Brugers = new HashSet<Bruger>();
            Udgivers = new HashSet<Udgiver>();
        }

        public string Postnr1 { get; set; }
        public string City { get; set; }

        public virtual ICollection<Bruger> Brugers { get; set; }
        public virtual ICollection<Udgiver> Udgivers { get; set; }
    }
}
