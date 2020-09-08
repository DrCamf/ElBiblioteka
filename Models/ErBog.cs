using System;
using System.Collections.Generic;

#nullable disable

namespace ElBiblioteka.Models
{
    public partial class ErBog
    {
        public ErBog()
        {
            UngBogs = new HashSet<UngBog>();
        }

        public int Id { get; set; }
        public string Isbn { get; set; }
        public string Udgave { get; set; }
        public int Omfang { get; set; }
        public int MedieId { get; set; }

        public virtual Medie Medie { get; set; }
        public virtual ICollection<UngBog> UngBogs { get; set; }
    }
}
