using System;
using System.Collections.Generic;

#nullable disable

namespace ElBiblioteka.Models
{
    public partial class UdeTid
    {
        public UdeTid()
        {
            ErUdes = new HashSet<ErUde>();
        }

        public int Id { get; set; }
        public string Periode { get; set; }

        public virtual ICollection<ErUde> ErUdes { get; set; }
    }
}
