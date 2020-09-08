using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace ElBiblioteka.Models
{
    public partial class NewBibContext : DbContext
    {
        public NewBibContext()
        {
        }

        public NewBibContext(DbContextOptions<NewBibContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Bruger> Brugers { get; set; }
        public virtual DbSet<BrugerKonto> BrugerKontos { get; set; }
        public virtual DbSet<BrugerType> BrugerTypes { get; set; }
        public virtual DbSet<DelAfSerie> DelAfSeries { get; set; }
        public virtual DbSet<Emner> Emners { get; set; }
        public virtual DbSet<ErBog> ErBogs { get; set; }
        public virtual DbSet<ErUde> ErUdes { get; set; }
        public virtual DbSet<Forfatter> Forfatters { get; set; }
        public virtual DbSet<ForfatterUdgivelser> ForfatterUdgivelsers { get; set; }
        public virtual DbSet<Format> Formats { get; set; }
        public virtual DbSet<FysiskPlacering> FysiskPlacerings { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }
        public virtual DbSet<HarFormat> HarFormats { get; set; }
        public virtual DbSet<HarGenre> HarGenres { get; set; }
        public virtual DbSet<HarIndhold> HarIndholds { get; set; }
        public virtual DbSet<HarReferat> HarReferats { get; set; }
        public virtual DbSet<Indhold> Indholds { get; set; }
        public virtual DbSet<KortReferat> KortReferats { get; set; }
        public virtual DbSet<MaalGruppe> MaalGruppes { get; set; }
        public virtual DbSet<Medie> Medice { get; set; }
        public virtual DbSet<MedieEmner> MedieEmners { get; set; }
        public virtual DbSet<MedieTilstand> MedieTilstands { get; set; }
        public virtual DbSet<MedieType> MedieTypes { get; set; }
        public virtual DbSet<MedieUd> MedieUds { get; set; }
        public virtual DbSet<Placering> Placerings { get; set; }
        public virtual DbSet<Postnr> Postnrs { get; set; }
        public virtual DbSet<Reservering> Reserverings { get; set; }
        public virtual DbSet<Serier> Seriers { get; set; }
        public virtual DbSet<Skyld> Skylds { get; set; }
        public virtual DbSet<SkyldSum> SkyldSums { get; set; }
        public virtual DbSet<UdeTid> UdeTids { get; set; }
        public virtual DbSet<Udgiver> Udgivers { get; set; }
        public virtual DbSet<UngBog> UngBogs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DOCSPOWERPC;Database=NewBib;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bruger>(entity =>
            {
                entity.ToTable("bruger");

                entity.HasAnnotation("Relational:IsTableExcludedFromMigrations", false);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Adresse)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("adresse");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created")
                    .HasDefaultValueSql("(getdate())")
                    .HasAnnotation("Relational:ColumnType", "datetime");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("first_name");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("last_name");

                entity.Property(e => e.Modified)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("modified");

                entity.Property(e => e.PostnrId)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("postnr_id")
                    .IsFixedLength(true);

                entity.Property(e => e.TlfNr).HasColumnName("tlf_nr");

                entity.HasOne(d => d.Postnr)
                    .WithMany(p => p.Brugers)
                    .HasForeignKey(x => x.PostnrId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__bruger__postnr_i__3A81B327");
            });

            modelBuilder.Entity<BrugerKonto>(entity =>
            {
                entity.ToTable("brugerKonto");

                entity.HasAnnotation("Relational:IsTableExcludedFromMigrations", false);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BrugerId).HasColumnName("bruger_id");

                entity.Property(e => e.BrugerTypeId).HasColumnName("brugerType_id");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created")
                    .HasDefaultValueSql("(getdate())")
                    .HasAnnotation("Relational:ColumnType", "datetime");

                entity.Property(e => e.Login).HasColumnName("login");

                entity.Property(e => e.Modified)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("modified");

                entity.Property(e => e.Password)
                    .HasMaxLength(1024)
                    .IsUnicode(false)
                    .HasColumnName("password");

                entity.HasOne(d => d.Bruger)
                    .WithMany(p => p.BrugerKontos)
                    .HasForeignKey(x => x.BrugerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__brugerKon__bruge__440B1D61");

                entity.HasOne(d => d.BrugerType)
                    .WithMany(p => p.BrugerKontos)
                    .HasForeignKey(x => x.BrugerTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__brugerKon__bruge__4316F928");
            });

            modelBuilder.Entity<BrugerType>(entity =>
            {
                entity.ToTable("brugerType");

                entity.HasAnnotation("Relational:IsTableExcludedFromMigrations", false);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Beskrivelse)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("beskrivelse")
                    .HasAnnotation("Relational:ColumnType", "text");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<DelAfSerie>(entity =>
            {
                entity.ToTable("delAfSerie");

                entity.HasAnnotation("Relational:IsTableExcludedFromMigrations", false);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.MedieId).HasColumnName("medie_id");

                entity.Property(e => e.SerieId).HasColumnName("serie_id");

                entity.Property(e => e.SerieNr).HasColumnName("serie_nr");

                entity.HasOne(d => d.Medie)
                    .WithMany(p => p.DelAfSeries)
                    .HasForeignKey(x => x.MedieId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__delAfSeri__medie__0A9D95DB");

                entity.HasOne(d => d.Serie)
                    .WithMany(p => p.DelAfSeries)
                    .HasForeignKey(x => x.SerieId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__delAfSeri__serie__09A971A2");
            });

            modelBuilder.Entity<Emner>(entity =>
            {
                entity.ToTable("emner");

                entity.HasAnnotation("Relational:IsTableExcludedFromMigrations", false);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(124)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<ErBog>(entity =>
            {
                entity.ToTable("erBog");

                entity.HasAnnotation("Relational:IsTableExcludedFromMigrations", false);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Isbn)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("isbn");

                entity.Property(e => e.MedieId).HasColumnName("medie_id");

                entity.Property(e => e.Omfang).HasColumnName("omfang");

                entity.Property(e => e.Udgave)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("udgave");

                entity.HasOne(d => d.Medie)
                    .WithMany(p => p.ErBogs)
                    .HasForeignKey(x => x.MedieId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__erBog__medie_id__70DDC3D8");
            });

            modelBuilder.Entity<ErUde>(entity =>
            {
                entity.ToTable("erUde");

                entity.HasAnnotation("Relational:IsTableExcludedFromMigrations", false);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.MedieId).HasColumnName("medie_id");

                entity.Property(e => e.UdetidId).HasColumnName("udetid_id");

                entity.HasOne(d => d.Medie)
                    .WithMany(p => p.ErUdes)
                    .HasForeignKey(x => x.MedieId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__erUde__medie_id__04E4BC85");

                entity.HasOne(d => d.Udetid)
                    .WithMany(p => p.ErUdes)
                    .HasForeignKey(x => x.UdetidId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__erUde__udetid_id__03F0984C");
            });

            modelBuilder.Entity<Forfatter>(entity =>
            {
                entity.ToTable("forfatter");

                entity.HasAnnotation("Relational:IsTableExcludedFromMigrations", false);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(124)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<ForfatterUdgivelser>(entity =>
            {
                entity.ToTable("forfatterUdgivelser");

                entity.HasAnnotation("Relational:IsTableExcludedFromMigrations", false);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ForfatterId).HasColumnName("forfatter_id");

                entity.Property(e => e.MedieId).HasColumnName("medie_id");

                entity.HasOne(d => d.Forfatter)
                    .WithMany(p => p.ForfatterUdgivelsers)
                    .HasForeignKey(x => x.ForfatterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__forfatter__forfa__6D0D32F4");

                entity.HasOne(d => d.Medie)
                    .WithMany(p => p.ForfatterUdgivelsers)
                    .HasForeignKey(x => x.MedieId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__forfatter__medie__6E01572D");
            });

            modelBuilder.Entity<Format>(entity =>
            {
                entity.ToTable("format");

                entity.HasAnnotation("Relational:IsTableExcludedFromMigrations", false);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Beskrivelse)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("beskrivelse")
                    .HasAnnotation("Relational:ColumnType", "text");
            });

            modelBuilder.Entity<FysiskPlacering>(entity =>
            {
                entity.ToTable("fysiskPlacering");

                entity.HasAnnotation("Relational:IsTableExcludedFromMigrations", false);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Sted)
                    .IsRequired()
                    .HasMaxLength(124)
                    .IsUnicode(false)
                    .HasColumnName("sted");
            });

            modelBuilder.Entity<Genre>(entity =>
            {
                entity.ToTable("genre");

                entity.HasAnnotation("Relational:IsTableExcludedFromMigrations", false);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(124)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<HarFormat>(entity =>
            {
                entity.ToTable("harFormat");

                entity.HasAnnotation("Relational:IsTableExcludedFromMigrations", false);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.FormatId).HasColumnName("format_id");

                entity.Property(e => e.MedieId).HasColumnName("medie_id");

                entity.HasOne(d => d.Format)
                    .WithMany(p => p.HarFormats)
                    .HasForeignKey(x => x.FormatId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__harFormat__forma__7E37BEF6");

                entity.HasOne(d => d.Medie)
                    .WithMany(p => p.HarFormats)
                    .HasForeignKey(x => x.MedieId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__harFormat__medie__7F2BE32F");
            });

            modelBuilder.Entity<HarGenre>(entity =>
            {
                entity.ToTable("harGenre");

                entity.HasAnnotation("Relational:IsTableExcludedFromMigrations", false);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.GenreId).HasColumnName("genre_id");

                entity.Property(e => e.MedieId).HasColumnName("medie_id");

                entity.HasOne(d => d.Genre)
                    .WithMany(p => p.HarGenres)
                    .HasForeignKey(x => x.GenreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__harGenre__genre___787EE5A0");

                entity.HasOne(d => d.Medie)
                    .WithMany(p => p.HarGenres)
                    .HasForeignKey(x => x.MedieId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__harGenre__medie___797309D9");
            });

            modelBuilder.Entity<HarIndhold>(entity =>
            {
                entity.ToTable("harIndhold");

                entity.HasAnnotation("Relational:IsTableExcludedFromMigrations", false);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IndholdId).HasColumnName("indhold_id");

                entity.Property(e => e.MedieId).HasColumnName("medie_id");

                entity.HasOne(d => d.Indhold)
                    .WithMany(p => p.HarIndholds)
                    .HasForeignKey(x => x.IndholdId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__harIndhol__indho__0F624AF8");

                entity.HasOne(d => d.Medie)
                    .WithMany(p => p.HarIndholds)
                    .HasForeignKey(x => x.MedieId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__harIndhol__medie__10566F31");
            });

            modelBuilder.Entity<HarReferat>(entity =>
            {
                entity.ToTable("harReferat");

                entity.HasAnnotation("Relational:IsTableExcludedFromMigrations", false);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.MedieId).HasColumnName("medie_id");

                entity.Property(e => e.ReferatId).HasColumnName("referat_id");

                entity.HasOne(d => d.Medie)
                    .WithMany(p => p.HarReferats)
                    .HasForeignKey(x => x.MedieId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__harRefera__medie__160F4887");

                entity.HasOne(d => d.Referat)
                    .WithMany(p => p.HarReferats)
                    .HasForeignKey(x => x.ReferatId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__harRefera__refer__151B244E");
            });

            modelBuilder.Entity<Indhold>(entity =>
            {
                entity.ToTable("indhold");

                entity.HasAnnotation("Relational:IsTableExcludedFromMigrations", false);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Beskrivelse)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("beskrivelse")
                    .HasAnnotation("Relational:ColumnType", "text");
            });

            modelBuilder.Entity<KortReferat>(entity =>
            {
                entity.ToTable("kortReferat");

                entity.HasAnnotation("Relational:IsTableExcludedFromMigrations", false);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Beskrivelse)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("beskrivelse")
                    .HasAnnotation("Relational:ColumnType", "text");
            });

            modelBuilder.Entity<MaalGruppe>(entity =>
            {
                entity.ToTable("maalGruppe");

                entity.HasAnnotation("Relational:IsTableExcludedFromMigrations", false);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(124)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Medie>(entity =>
            {
                entity.ToTable("medie");

                entity.HasAnnotation("Relational:IsTableExcludedFromMigrations", false);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AlderId).HasColumnName("alder_id");

                entity.Property(e => e.OprettelseDato)
                    .HasColumnType("datetime")
                    .HasColumnName("oprettelse_dato")
                    .HasAnnotation("Relational:ColumnType", "datetime");

                entity.Property(e => e.PlaceringId).HasColumnName("placering_id");

                entity.Property(e => e.Sprog)
                    .IsRequired()
                    .HasMaxLength(124)
                    .IsUnicode(false)
                    .HasColumnName("sprog");

                entity.Property(e => e.TilstandId).HasColumnName("tilstand_id");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("title");

                entity.Property(e => e.TypeId).HasColumnName("type_id");

                entity.Property(e => e.UdgivelseDato)
                    .HasColumnType("datetime")
                    .HasColumnName("udgivelse_dato")
                    .HasAnnotation("Relational:ColumnType", "datetime");

                entity.Property(e => e.UdgiverId).HasColumnName("udgiver_ID");

                entity.HasOne(d => d.Alder)
                    .WithMany(p => p.Medice)
                    .HasForeignKey(x => x.AlderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__medie__alder_id__5629CD9C");

                entity.HasOne(d => d.Placering)
                    .WithMany(p => p.Medice)
                    .HasForeignKey(x => x.PlaceringId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__medie__placering__5535A963");

                entity.HasOne(d => d.Tilstand)
                    .WithMany(p => p.Medice)
                    .HasForeignKey(x => x.TilstandId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__medie__tilstand___534D60F1");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.Medice)
                    .HasForeignKey(x => x.TypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__medie__type_id__5441852A");

                entity.HasOne(d => d.Udgiver)
                    .WithMany(p => p.Medice)
                    .HasForeignKey(x => x.UdgiverId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__medie__udgiver_I__571DF1D5");
            });

            modelBuilder.Entity<MedieEmner>(entity =>
            {
                entity.ToTable("medieEmner");

                entity.HasAnnotation("Relational:IsTableExcludedFromMigrations", false);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.EmneId).HasColumnName("emne_id");

                entity.Property(e => e.MedieId).HasColumnName("medie_id");

                entity.HasOne(d => d.Emne)
                    .WithMany(p => p.MedieEmners)
                    .HasForeignKey(x => x.EmneId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__medieEmne__emne___6754599E");

                entity.HasOne(d => d.Medie)
                    .WithMany(p => p.MedieEmners)
                    .HasForeignKey(x => x.MedieId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__medieEmne__medie__68487DD7");
            });

            modelBuilder.Entity<MedieTilstand>(entity =>
            {
                entity.ToTable("medieTilstand");

                entity.HasAnnotation("Relational:IsTableExcludedFromMigrations", false);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<MedieType>(entity =>
            {
                entity.ToTable("medieType");

                entity.HasAnnotation("Relational:IsTableExcludedFromMigrations", false);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<MedieUd>(entity =>
            {
                entity.ToTable("medieUd");

                entity.HasAnnotation("Relational:IsTableExcludedFromMigrations", false);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ForventetDato)
                    .HasColumnType("datetime")
                    .HasColumnName("forventet_dato")
                    .HasAnnotation("Relational:ColumnType", "datetime");

                entity.Property(e => e.IndDato)
                    .HasColumnType("datetime")
                    .HasColumnName("ind_dato")
                    .HasAnnotation("Relational:ColumnType", "datetime");

                entity.Property(e => e.KontoId).HasColumnName("konto_id");

                entity.Property(e => e.MedieId).HasColumnName("medie_id");

                entity.Property(e => e.UdDato)
                    .HasColumnType("datetime")
                    .HasColumnName("ud_dato")
                    .HasAnnotation("Relational:ColumnType", "datetime");

                entity.HasOne(d => d.Konto)
                    .WithMany(p => p.MedieUds)
                    .HasForeignKey(x => x.KontoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__medieUd__konto_i__5DCAEF64");

                entity.HasOne(d => d.Medie)
                    .WithMany(p => p.MedieUds)
                    .HasForeignKey(x => x.MedieId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__medieUd__medie_i__5EBF139D");
            });

            modelBuilder.Entity<Placering>(entity =>
            {
                entity.ToTable("placering");

                entity.HasAnnotation("Relational:IsTableExcludedFromMigrations", false);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Dk5)
                    .IsRequired()
                    .HasMaxLength(124)
                    .IsUnicode(false)
                    .HasColumnName("DK5");

                entity.Property(e => e.FysiskPlaceringId).HasColumnName("fysiskPlacering_id");

                entity.HasOne(d => d.FysiskPlacering)
                    .WithMany(p => p.Placerings)
                    .HasForeignKey(x => x.FysiskPlaceringId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__placering__fysis__4E88ABD4");
            });

            modelBuilder.Entity<Postnr>(entity =>
            {
                entity.HasKey(x => x.Postnr1)
                    .HasName("PK__postnr__DD0116666D03AE17");

                entity.ToTable("postnr");

                entity.HasAnnotation("Relational:IsTableExcludedFromMigrations", false);

                entity.Property(e => e.Postnr1)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("postnr")
                    .IsFixedLength(true);

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("city");
            });

            modelBuilder.Entity<Reservering>(entity =>
            {
                entity.ToTable("reservering");

                entity.HasAnnotation("Relational:IsTableExcludedFromMigrations", false);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ErAnnulleret).HasColumnName("er_annulleret");

                entity.Property(e => e.InteresseDato)
                    .HasColumnType("datetime")
                    .HasColumnName("interesse_dato")
                    .HasAnnotation("Relational:ColumnType", "datetime");

                entity.Property(e => e.KontoId).HasColumnName("konto_id");

                entity.Property(e => e.MedieId).HasColumnName("medie_id");

                entity.Property(e => e.OprettelseDato)
                    .HasColumnType("datetime")
                    .HasColumnName("oprettelse_dato")
                    .HasAnnotation("Relational:ColumnType", "datetime");

                entity.HasOne(d => d.Konto)
                    .WithMany(p => p.Reserverings)
                    .HasForeignKey(x => x.KontoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__reserveri__konto__59FA5E80");

                entity.HasOne(d => d.Medie)
                    .WithMany(p => p.Reserverings)
                    .HasForeignKey(x => x.MedieId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__reserveri__medie__5AEE82B9");
            });

            modelBuilder.Entity<Serier>(entity =>
            {
                entity.ToTable("serier");

                entity.HasAnnotation("Relational:IsTableExcludedFromMigrations", false);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(124)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Skyld>(entity =>
            {
                entity.ToTable("skyld");

                entity.HasAnnotation("Relational:IsTableExcludedFromMigrations", false);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.SkyldsumId).HasColumnName("skyldsum_id");

                entity.Property(e => e.UdId).HasColumnName("ud_id");

                entity.HasOne(d => d.Skyldsum)
                    .WithMany(p => p.Skylds)
                    .HasForeignKey(x => x.SkyldsumId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__skyld__skyldsum___619B8048");

                entity.HasOne(d => d.Ud)
                    .WithMany(p => p.Skylds)
                    .HasForeignKey(x => x.UdId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__skyld__ud_id__628FA481");
            });

            modelBuilder.Entity<SkyldSum>(entity =>
            {
                entity.ToTable("skyldSum");

                entity.HasAnnotation("Relational:IsTableExcludedFromMigrations", false);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Beskrivelse)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("beskrivelse")
                    .HasAnnotation("Relational:ColumnType", "text");

                entity.Property(e => e.Sum).HasColumnName("sum");
            });

            modelBuilder.Entity<UdeTid>(entity =>
            {
                entity.ToTable("udeTid");

                entity.HasAnnotation("Relational:IsTableExcludedFromMigrations", false);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Periode)
                    .IsRequired()
                    .HasMaxLength(44)
                    .IsUnicode(false)
                    .HasColumnName("periode");
            });

            modelBuilder.Entity<Udgiver>(entity =>
            {
                entity.ToTable("udgiver");

                entity.HasAnnotation("Relational:IsTableExcludedFromMigrations", false);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Adresse)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("adresse");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.PostnrId)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("postnr_id")
                    .IsFixedLength(true);

                entity.Property(e => e.TlfNr).HasColumnName("tlf_nr");

                entity.HasOne(d => d.Postnr)
                    .WithMany(p => p.Udgivers)
                    .HasForeignKey(x => x.PostnrId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__udgiver__postnr___3D5E1FD2");
            });

            modelBuilder.Entity<UngBog>(entity =>
            {
                entity.ToTable("ungBog");

                entity.HasAnnotation("Relational:IsTableExcludedFromMigrations", false);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BogId).HasColumnName("bog_id");

                entity.Property(e => e.Lettal)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("lettal");

                entity.Property(e => e.Lixtal)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("lixtal");

                entity.Property(e => e.Lustal)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("lustal");

                entity.HasOne(d => d.Bog)
                    .WithMany(p => p.UngBogs)
                    .HasForeignKey(x => x.BogId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ungBog__bog_id__73BA3083");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
