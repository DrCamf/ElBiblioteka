using System;
using System.Collections.Generic;

#nullable disable

namespace ElBiblioteka.Models
{
    public partial class Emner
    {
        public Emner()
        {
            MedieEmners = new HashSet<MedieEmner>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<MedieEmner> MedieEmners { get; set; }
    }
}
