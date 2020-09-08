using System;
using System.Collections.Generic;

#nullable disable

namespace ElBiblioteka.Models
{
    public partial class Format
    {
        public Format()
        {
            HarFormats = new HashSet<HarFormat>();
        }

        public int Id { get; set; }
        public string Beskrivelse { get; set; }

        public virtual ICollection<HarFormat> HarFormats { get; set; }
    }
}
