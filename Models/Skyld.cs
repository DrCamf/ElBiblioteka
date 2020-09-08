using System;
using System.Collections.Generic;

#nullable disable

namespace ElBiblioteka.Models
{
    public partial class Skyld
    {
        public int Id { get; set; }
        public int SkyldsumId { get; set; }
        public int UdId { get; set; }

        public virtual SkyldSum Skyldsum { get; set; }
        public virtual MedieUd Ud { get; set; }
    }
}
