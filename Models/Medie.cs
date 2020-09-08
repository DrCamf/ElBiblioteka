using System;
using System.Collections.Generic;

#nullable disable

namespace ElBiblioteka.Models
{
    public partial class Medie
    {
        public Medie()
        {
            DelAfSeries = new HashSet<DelAfSerie>();
            ErBogs = new HashSet<ErBog>();
            ErUdes = new HashSet<ErUde>();
            ForfatterUdgivelsers = new HashSet<ForfatterUdgivelser>();
            HarFormats = new HashSet<HarFormat>();
            HarGenres = new HashSet<HarGenre>();
            HarIndholds = new HashSet<HarIndhold>();
            HarReferats = new HashSet<HarReferat>();
            MedieEmners = new HashSet<MedieEmner>();
            MedieUds = new HashSet<MedieUd>();
            Reserverings = new HashSet<Reservering>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime UdgivelseDato { get; set; }
        public DateTime OprettelseDato { get; set; }
        public string Sprog { get; set; }
        public int TilstandId { get; set; }
        public int TypeId { get; set; }
        public int PlaceringId { get; set; }
        public int AlderId { get; set; }
        public int UdgiverId { get; set; }

        public virtual MaalGruppe Alder { get; set; }
        public virtual Placering Placering { get; set; }
        public virtual MedieTilstand Tilstand { get; set; }
        public virtual MedieType Type { get; set; }
        public virtual Udgiver Udgiver { get; set; }
        public virtual ICollection<DelAfSerie> DelAfSeries { get; set; }
        public virtual ICollection<ErBog> ErBogs { get; set; }
        public virtual ICollection<ErUde> ErUdes { get; set; }
        public virtual ICollection<ForfatterUdgivelser> ForfatterUdgivelsers { get; set; }
        public virtual ICollection<HarFormat> HarFormats { get; set; }
        public virtual ICollection<HarGenre> HarGenres { get; set; }
        public virtual ICollection<HarIndhold> HarIndholds { get; set; }
        public virtual ICollection<HarReferat> HarReferats { get; set; }
        public virtual ICollection<MedieEmner> MedieEmners { get; set; }
        public virtual ICollection<MedieUd> MedieUds { get; set; }
        public virtual ICollection<Reservering> Reserverings { get; set; }
    }
}
