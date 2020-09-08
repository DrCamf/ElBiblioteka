using System;
using System.Collections.Generic;

#nullable disable

namespace ElBiblioteka.Models
{
    public partial class ErUde
    {
        public int Id { get; set; }
        public int UdetidId { get; set; }
        public int MedieId { get; set; }

        public virtual Medie Medie { get; set; }
        public virtual UdeTid Udetid { get; set; }
    }
}
