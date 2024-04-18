using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace TheWitcherEnciclopediaBack.Models;

public partial class TheWitcherEncyclopediaContext : DbContext
{
    public TheWitcherEncyclopediaContext()
    {
    }

    public TheWitcherEncyclopediaContext(DbContextOptions<TheWitcherEncyclopediaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ArteDiseno> ArteDisenos { get; set; }

    public virtual DbSet<Bestiario> Bestiarios { get; set; }

    public virtual DbSet<Curiosidade> Curiosidades { get; set; }

    public virtual DbSet<HistoriaTrama> HistoriaTramas { get; set; }

    public virtual DbSet<Localizacione> Localizaciones { get; set; }

    public virtual DbSet<Personaje> Personajes { get; set; }

    public virtual DbSet<SistemaJuego> SistemaJuegos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=PCESCRITORIO-MO;Database=TheWitcherEncyclopedia;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ArteDiseno>(entity =>
        {
            entity.HasKey(e => e.ArteId).HasName("PK__ArteDise__FD8C1FA6E20BAF88");

            entity.ToTable("ArteDiseno");

            entity.Property(e => e.ArteId).HasColumnName("ArteID");
            entity.Property(e => e.TipoArte).HasMaxLength(100);
        });

        modelBuilder.Entity<Bestiario>(entity =>
        {
            entity.HasKey(e => e.MonstruoId).HasName("PK__Bestiari__1C04D70F37F3B508");

            entity.ToTable("Bestiario");

            entity.Property(e => e.MonstruoId).HasColumnName("MonstruoID");
            entity.Property(e => e.Nombre).HasMaxLength(255);
        });

        modelBuilder.Entity<Curiosidade>(entity =>
        {
            entity.HasKey(e => e.CuriosidadId).HasName("PK__Curiosid__40787575D585310B");

            entity.Property(e => e.CuriosidadId).HasColumnName("CuriosidadID");
        });

        modelBuilder.Entity<HistoriaTrama>(entity =>
        {
            entity.HasKey(e => e.JuegoId).HasName("PK__Historia__F76C1B25B6455676");

            entity.ToTable("HistoriaTrama");

            entity.Property(e => e.JuegoId).HasColumnName("JuegoID");
            entity.Property(e => e.Titulo).HasMaxLength(255);
        });

        modelBuilder.Entity<Localizacione>(entity =>
        {
            entity.HasKey(e => e.LugarId).HasName("PK__Localiza__1BDE0D80216740C5");

            entity.Property(e => e.LugarId).HasColumnName("LugarID");
            entity.Property(e => e.Nombre).HasMaxLength(255);
            entity.Property(e => e.Reino).HasMaxLength(100);
        });

        modelBuilder.Entity<Personaje>(entity =>
        {
            entity.HasKey(e => e.PersonajeId).HasName("PK__Personaj__FF7028BD1805ACE5");

            entity.Property(e => e.PersonajeId).HasColumnName("PersonajeID");
            entity.Property(e => e.Nombre).HasMaxLength(255);
        });

        modelBuilder.Entity<SistemaJuego>(entity =>
        {
            entity.HasKey(e => e.MecanicaId).HasName("PK__SistemaJ__D56895EA64983181");

            entity.ToTable("SistemaJuego");

            entity.Property(e => e.MecanicaId).HasColumnName("MecanicaID");
            entity.Property(e => e.Tipo).HasMaxLength(100);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
