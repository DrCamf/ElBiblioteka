using System;
using System.Collections.Generic;

#nullable disable

namespace ElBiblioteka.Models
{
    public partial class UngBog
    {
        public int Id { get; set; }
        public string Lixtal { get; set; }
        public string Lettal { get; set; }
        public string Lustal { get; set; }
        public int BogId { get; set; }

        public virtual ErBog Bog { get; set; }
    }
}
