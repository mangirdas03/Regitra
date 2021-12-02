using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace RegitraISP.Models
{
    public partial class regitraispContext : DbContext
    {
        public regitraispContext()
        {
        }

        public regitraispContext(DbContextOptions<regitraispContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Apeliacija> Apeliacijas { get; set; }
        public virtual DbSet<Automobili> Automobilis { get; set; }
        public virtual DbSet<AutomobilioPasa> AutomobilioPasas { get; set; }
        public virtual DbSet<Darbuotoja> Darbuotojas { get; set; }
        public virtual DbSet<Egzamina> Egzaminas { get; set; }
        public virtual DbSet<EgzaminoTipa> EgzaminoTipas { get; set; }
        public virtual DbSet<Filiala> Filialas { get; set; }
        public virtual DbSet<Klienta> Klientas { get; set; }
        public virtual DbSet<Miesta> Miestas { get; set; }
        public virtual DbSet<PazymejimoBukle> PazymejimoBukles { get; set; }
        public virtual DbSet<TechnineApziura> TechnineApziuras { get; set; }
        public virtual DbSet<VairuotojoPazymejima> VairuotojoPazymejimas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySQL("server=localhost; port=3306; user=root; password=; database=regitraisp");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Apeliacija>(entity =>
            {
                entity.HasKey(e => e.IdApeliacija)
                    .HasName("PRIMARY");

                entity.ToTable("apeliacija");

                entity.HasIndex(e => e.FkKlientasasmensKodas, "pildo");

                entity.Property(e => e.IdApeliacija)
                    .HasColumnType("int(11)")
                    .HasColumnName("id_Apeliacija");

                entity.Property(e => e.FkKlientasasmensKodas)
                    .IsRequired()
                    .HasMaxLength(12)
                    .HasColumnName("fk_Klientasasmens_kodas");

                entity.Property(e => e.Priezastis)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("priezastis");

                entity.Property(e => e.Tekstas)
                    .IsRequired()
                    .HasColumnName("tekstas");

                entity.HasOne(d => d.FkKlientasasmensKodasNavigation)
                    .WithMany(p => p.Apeliacijas)
                    .HasForeignKey(d => d.FkKlientasasmensKodas)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("pildo");
            });

            modelBuilder.Entity<Automobili>(entity =>
            {
                entity.HasKey(e => e.Vin)
                    .HasName("PRIMARY");

                entity.ToTable("automobilis");

                entity.HasIndex(e => e.FkKlientasasmensKodas, "priklauso");

                entity.Property(e => e.Vin)
                    .HasMaxLength(18)
                    .HasColumnName("vin");

                entity.Property(e => e.FkKlientasasmensKodas)
                    .IsRequired()
                    .HasMaxLength(12)
                    .HasColumnName("fk_Klientasasmens_kodas");

                entity.Property(e => e.Marke)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasColumnName("marke");

                entity.Property(e => e.Modelis)
                    .IsRequired()
                    .HasMaxLength(35)
                    .HasColumnName("modelis");

                entity.Property(e => e.PagaminimoMetai)
                    .HasColumnType("date")
                    .HasColumnName("pagaminimo_metai");

                entity.Property(e => e.PaskutineRegSalis)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("paskutine_reg_salis");

                entity.Property(e => e.PirmojiRegSalis)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("pirmoji_reg_salis");

                entity.Property(e => e.Sdk)
                    .IsRequired()
                    .HasMaxLength(9)
                    .HasColumnName("sdk");

                entity.Property(e => e.ValstybiniaiNumeriai)
                    .IsRequired()
                    .HasMaxLength(7)
                    .HasColumnName("valstybiniai_numeriai");

                entity.HasOne(d => d.FkKlientasasmensKodasNavigation)
                    .WithMany(p => p.Automobilis)
                    .HasForeignKey(d => d.FkKlientasasmensKodas)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("priklauso");
            });

            modelBuilder.Entity<AutomobilioPasa>(entity =>
            {
                entity.HasKey(e => e.PasoNr)
                    .HasName("PRIMARY");

                entity.ToTable("automobilio_pasas");

                entity.HasIndex(e => e.FkDarbuotojastabelioNr, "sudaro");

                entity.HasIndex(e => e.FkAutomobilisvin, "suteikiamas_vin");

                entity.Property(e => e.PasoNr)
                    .HasColumnType("int(11)")
                    .HasColumnName("paso_nr");

                entity.Property(e => e.AutomobilioSpalva)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasColumnName("automobilio_spalva");

                entity.Property(e => e.Co2Kiekis)
                    .HasColumnType("int(11)")
                    .HasColumnName("co2_kiekis");

                entity.Property(e => e.FkAutomobilisvin)
                    .IsRequired()
                    .HasMaxLength(18)
                    .HasColumnName("fk_Automobilisvin");

                entity.Property(e => e.FkDarbuotojastabelioNr)
                    .HasColumnType("int(11)")
                    .HasColumnName("fk_Darbuotojastabelio_nr");

                entity.Property(e => e.IsdavimoData)
                    .HasColumnType("date")
                    .HasColumnName("isdavimo_data");

                entity.Property(e => e.KilovatuSkaicius)
                    .HasColumnType("int(11)")
                    .HasColumnName("kilovatu_skaicius");

                entity.Property(e => e.KuroTipas)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("kuro_tipas");

                entity.Property(e => e.Svoris)
                    .HasColumnType("int(11)")
                    .HasColumnName("svoris");

                entity.Property(e => e.VariklioLitrazas).HasColumnName("variklio_litrazas");

                entity.HasOne(d => d.FkAutomobilisvinNavigation)
                    .WithMany(p => p.AutomobilioPasas)
                    .HasForeignKey(d => d.FkAutomobilisvin)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("suteikiamas_vin");

                entity.HasOne(d => d.FkDarbuotojastabelioNrNavigation)
                    .WithMany(p => p.AutomobilioPasas)
                    .HasForeignKey(d => d.FkDarbuotojastabelioNr)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("sudaro");
            });

            modelBuilder.Entity<Darbuotoja>(entity =>
            {
                entity.HasKey(e => e.TabelioNr)
                    .HasName("PRIMARY");

                entity.ToTable("darbuotojas");

                entity.HasIndex(e => e.FkFilialasidFilialas, "dirba");

                entity.Property(e => e.TabelioNr)
                    .HasColumnType("int(11)")
                    .HasColumnName("tabelio_nr");

                entity.Property(e => e.FkFilialasidFilialas)
                    .HasColumnType("int(11)")
                    .HasColumnName("fk_Filialasid_Filialas");

                entity.Property(e => e.Pavarde)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasColumnName("pavarde");

                entity.Property(e => e.Vardas)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasColumnName("vardas");

                entity.HasOne(d => d.FkFilialasidFilialasNavigation)
                    .WithMany(p => p.Darbuotojas)
                    .HasForeignKey(d => d.FkFilialasidFilialas)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("dirba");
            });

            modelBuilder.Entity<Egzamina>(entity =>
            {
                entity.HasKey(e => e.IdEgzaminas)
                    .HasName("PRIMARY");

                entity.ToTable("egzaminas");

                entity.HasIndex(e => e.EgzaminoTipas, "egzamino_tipas");

                entity.HasIndex(e => e.FkKlientasasmensKodas, "laiko");

                entity.HasIndex(e => e.FkFilialasidFilialas, "laikomas");

                entity.Property(e => e.IdEgzaminas)
                    .HasColumnType("int(11)")
                    .HasColumnName("id_Egzaminas");

                entity.Property(e => e.Data)
                    .HasColumnType("date")
                    .HasColumnName("data");

                entity.Property(e => e.EgzaminoTipas)
                    .HasColumnType("int(11)")
                    .HasColumnName("egzamino_tipas");

                entity.Property(e => e.FkFilialasidFilialas)
                    .HasColumnType("int(11)")
                    .HasColumnName("fk_Filialasid_Filialas");

                entity.Property(e => e.FkKlientasasmensKodas)
                    .IsRequired()
                    .HasMaxLength(12)
                    .HasColumnName("fk_Klientasasmens_kodas");

                entity.HasOne(d => d.EgzaminoTipasNavigation)
                    .WithMany(p => p.Egzaminas)
                    .HasForeignKey(d => d.EgzaminoTipas)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("egzaminas_ibfk_1");

                entity.HasOne(d => d.FkFilialasidFilialasNavigation)
                    .WithMany(p => p.Egzaminas)
                    .HasForeignKey(d => d.FkFilialasidFilialas)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("laikomas");

                entity.HasOne(d => d.FkKlientasasmensKodasNavigation)
                    .WithMany(p => p.Egzaminas)
                    .HasForeignKey(d => d.FkKlientasasmensKodas)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("laiko");
            });

            modelBuilder.Entity<EgzaminoTipa>(entity =>
            {
                entity.HasKey(e => e.IdEgzaminoTipas)
                    .HasName("PRIMARY");

                entity.ToTable("egzamino_tipas");

                entity.Property(e => e.IdEgzaminoTipas)
                    .HasColumnType("int(11)")
                    .HasColumnName("id_egzamino_tipas");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("name")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Filiala>(entity =>
            {
                entity.HasKey(e => e.IdFilialas)
                    .HasName("PRIMARY");

                entity.ToTable("filialas");

                entity.HasIndex(e => e.FkMiestaspavadinimas, "turi");

                entity.Property(e => e.IdFilialas)
                    .HasColumnType("int(11)")
                    .HasColumnName("id_Filialas");

                entity.Property(e => e.FkMiestaspavadinimas)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("fk_Miestaspavadinimas");

                entity.Property(e => e.Gatve)
                    .IsRequired()
                    .HasMaxLength(75)
                    .HasColumnName("gatve");

                entity.Property(e => e.GatvesNr)
                    .HasColumnType("int(11)")
                    .HasColumnName("gatves_nr");

                entity.Property(e => e.PraktikosEgz)
                    .HasColumnName("praktikos_egz")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.TeorijosEgz)
                    .HasColumnName("teorijos_egz")
                    .HasDefaultValueSql("'NULL'");

                entity.HasOne(d => d.FkMiestaspavadinimasNavigation)
                    .WithMany(p => p.Filialas)
                    .HasForeignKey(d => d.FkMiestaspavadinimas)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("turi");
            });

            modelBuilder.Entity<Klienta>(entity =>
            {
                entity.HasKey(e => e.AsmensKodas)
                    .HasName("PRIMARY");

                entity.ToTable("klientas");

                entity.Property(e => e.AsmensKodas)
                    .HasMaxLength(12)
                    .HasColumnName("asmens_kodas");

                entity.Property(e => e.ElPastas)
                    .IsRequired()
                    .HasMaxLength(75)
                    .HasColumnName("el_pastas");

                entity.Property(e => e.Nuotrauka)
                    .HasColumnType("longblob")
                    .HasColumnName("nuotrauka")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Pavarde)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasColumnName("pavarde");

                entity.Property(e => e.PraktikosEgzData)
                    .HasColumnType("date")
                    .HasColumnName("praktikos_egz_data")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PraktikosEgzIslaikytas).HasColumnName("praktikos_egz_islaikytas");

                entity.Property(e => e.TelNr)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("tel_nr");

                entity.Property(e => e.TeorijosEgzData)
                    .HasColumnType("date")
                    .HasColumnName("teorijos_egz_data")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.TeorijosEgzIslaikytas).HasColumnName("teorijos_egz_islaikytas");

                entity.Property(e => e.Vardas)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasColumnName("vardas");
            });

            modelBuilder.Entity<Miesta>(entity =>
            {
                entity.HasKey(e => e.Pavadinimas)
                    .HasName("PRIMARY");

                entity.ToTable("miestas");

                entity.Property(e => e.Pavadinimas)
                    .HasMaxLength(50)
                    .HasColumnName("pavadinimas");
            });

            modelBuilder.Entity<PazymejimoBukle>(entity =>
            {
                entity.HasKey(e => e.IdPazymejimoBukle)
                    .HasName("PRIMARY");

                entity.ToTable("pazymejimo_bukle");

                entity.Property(e => e.IdPazymejimoBukle)
                    .HasColumnType("int(11)")
                    .HasColumnName("id_pazymejimo_bukle");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("name")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<TechnineApziura>(entity =>
            {
                entity.HasKey(e => e.ApziurosId)
                    .HasName("PRIMARY");

                entity.ToTable("technine_apziura");

                entity.HasIndex(e => e.FkDarbuotojastabelioNr, "atlieka");

                entity.HasIndex(e => e.FkAutomobilisvin, "atliekama");

                entity.Property(e => e.ApziurosId)
                    .HasColumnType("int(11)")
                    .HasColumnName("apziuros_id");

                entity.Property(e => e.AtlikimoData)
                    .HasColumnType("date")
                    .HasColumnName("atlikimo_data");

                entity.Property(e => e.DabartineRida)
                    .IsRequired()
                    .HasMaxLength(7)
                    .HasColumnName("dabartine_rida");

                entity.Property(e => e.Dumingumas).HasColumnName("dumingumas");

                entity.Property(e => e.FkAutomobilisvin)
                    .IsRequired()
                    .HasMaxLength(18)
                    .HasColumnName("fk_Automobilisvin");

                entity.Property(e => e.FkDarbuotojastabelioNr)
                    .HasColumnType("int(11)")
                    .HasColumnName("fk_Darbuotojastabelio_nr");

                entity.Property(e => e.GaliojimoData)
                    .HasColumnType("date")
                    .HasColumnName("galiojimo_data");

                entity.Property(e => e.KebuloBukle)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("kebulo_bukle");

                entity.Property(e => e.Pastabos)
                    .HasColumnName("pastabos")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.VariklioBukle)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("variklio_bukle");

                entity.Property(e => e.VaziuoklesBukle)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("vaziuokles_bukle");

                entity.HasOne(d => d.FkAutomobilisvinNavigation)
                    .WithMany(p => p.TechnineApziuras)
                    .HasForeignKey(d => d.FkAutomobilisvin)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("atliekama");

                entity.HasOne(d => d.FkDarbuotojastabelioNrNavigation)
                    .WithMany(p => p.TechnineApziuras)
                    .HasForeignKey(d => d.FkDarbuotojastabelioNr)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("atlieka");
            });

            modelBuilder.Entity<VairuotojoPazymejima>(entity =>
            {
                entity.HasKey(e => e.PazymejimoNr)
                    .HasName("PRIMARY");

                entity.ToTable("vairuotojo_pazymejimas");

                entity.HasIndex(e => e.PazymejimoBukle, "pazymejimo_bukle");

                entity.HasIndex(e => e.FkKlientasasmensKodas, "suteikiamas");

                entity.Property(e => e.PazymejimoNr)
                    .HasColumnType("int(11)")
                    .HasColumnName("pazymejimo_nr");

                entity.Property(e => e.FkKlientasasmensKodas)
                    .IsRequired()
                    .HasMaxLength(12)
                    .HasColumnName("fk_Klientasasmens_kodas");

                entity.Property(e => e.GaliojimoData)
                    .HasColumnType("date")
                    .HasColumnName("galiojimo_data");

                entity.Property(e => e.PagaminimoData)
                    .HasColumnType("date")
                    .HasColumnName("pagaminimo_data");

                entity.Property(e => e.PazymejimoBukle)
                    .HasColumnType("int(11)")
                    .HasColumnName("pazymejimo_bukle");

                entity.HasOne(d => d.FkKlientasasmensKodasNavigation)
                    .WithMany(p => p.VairuotojoPazymejimas)
                    .HasForeignKey(d => d.FkKlientasasmensKodas)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("suteikiamas");

                entity.HasOne(d => d.PazymejimoBukleNavigation)
                    .WithMany(p => p.VairuotojoPazymejimas)
                    .HasForeignKey(d => d.PazymejimoBukle)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("vairuotojo_pazymejimas_ibfk_1");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
