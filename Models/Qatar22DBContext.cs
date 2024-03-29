﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace NuevaDB_Qatar22.Models
{
    public partial class Qatar22DBContext : DbContext
    {
        public Qatar22DBContext()
        {
        }

        public Qatar22DBContext(DbContextOptions<Qatar22DBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Ciudade> Ciudades { get; set; }
        public virtual DbSet<Clima> Climas { get; set; }
        public virtual DbSet<Clube> Clubes { get; set; }
        public virtual DbSet<Estadio> Estadios { get; set; }
        public virtual DbSet<EstadisticasDeEquipoEnPartido> EstadisticasDeEquipoEnPartidos { get; set; }
        public virtual DbSet<EstadisticasDelPartido> EstadisticasDelPartidos { get; set; }
        public virtual DbSet<EstadisticasTotalesDelEquipo> EstadisticasTotalesDelEquipos { get; set; }
        public virtual DbSet<EstadoDePartido> EstadoDePartidos { get; set; }
        public virtual DbSet<Fase> Fases { get; set; }
        public virtual DbSet<Fgrupo> Fgrupos { get; set; }
        public virtual DbSet<Jugadore> Jugadores { get; set; }
        public virtual DbSet<Paise> Paises { get; set; }
        public virtual DbSet<Partido> Partidos { get; set; }
        public virtual DbSet<Plantilla> Plantillas { get; set; }
        public virtual DbSet<Posicione> Posiciones { get; set; }
        public virtual DbSet<SeleccionesEnGrupo> SeleccionesEnGrupos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB; Database=Qatar22DB; Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Ciudade>(entity =>
            {
                entity.HasKey(e => e.IdCiudad)
                    .HasName("PK_Table_1");

                entity.Property(e => e.IdCiudad).HasColumnName("id_Ciudad");

                entity.Property(e => e.FkIdPaís).HasColumnName("FK_id_país");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.FkIdPaísNavigation)
                    .WithMany(p => p.Ciudades)
                    .HasForeignKey(d => d.FkIdPaís)
                    .HasConstraintName("FK_Ciudades_Países");
            });

            modelBuilder.Entity<Clima>(entity =>
            {
                entity.HasKey(e => e.IdClima)
                    .HasName("PK_Clima");

                entity.Property(e => e.IdClima).HasColumnName("id_clima");

                entity.Property(e => e.Clima1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("clima");
            });

            modelBuilder.Entity<Clube>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Club)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Estadio>(entity =>
            {
                entity.HasKey(e => e.IdEstadio);

                entity.Property(e => e.IdEstadio).HasColumnName("Id_Estadio");

                entity.Property(e => e.FkIdCiudad).HasColumnName("FK_id_ciudad");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.FkIdCiudadNavigation)
                    .WithMany(p => p.Estadios)
                    .HasForeignKey(d => d.FkIdCiudad)
                    .HasConstraintName("FK_Estadios_Ciudades");
            });

            modelBuilder.Entity<EstadisticasDeEquipoEnPartido>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("EstadisticasDeEquipoEnPartido");

                entity.Property(e => e.FkIdPartido).HasColumnName("FK_id_partido");

                entity.Property(e => e.FkIdPaís).HasColumnName("FK_id_país");

                entity.HasOne(d => d.FkIdPartidoNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.FkIdPartido)
                    .HasConstraintName("FK_Estadisticas de Equipo en Partido_Partidos");

                entity.HasOne(d => d.FkIdPaísNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.FkIdPaís)
                    .HasConstraintName("FK_Estadisticas de Equipo en Partido_Países");
            });

            modelBuilder.Entity<EstadisticasDelPartido>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("EstadisticasDelPartido");

                entity.Property(e => e.FkIdPartido).HasColumnName("FK_id_partido");

                entity.Property(e => e.TiempoJugado).HasColumnName("Tiempo_Jugado");

                entity.HasOne(d => d.FkIdPartidoNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.FkIdPartido)
                    .HasConstraintName("FK_Estadisticas Del Partido_Partidos");
            });

            modelBuilder.Entity<EstadisticasTotalesDelEquipo>(entity =>
            {
                entity.HasKey(e => e.EstTotalEquipoId)
                    .HasName("PK_Estadisticas Totales del Equipo");

                entity.ToTable("EstadisticasTotalesDelEquipo");

                entity.Property(e => e.EstTotalEquipoId).ValueGeneratedNever();

                entity.Property(e => e.FkIdFase).HasColumnName("FK_id_fase");

                entity.Property(e => e.FkIdPaís).HasColumnName("FK_id_país");

                entity.Property(e => e.Gc).HasColumnName("GC");

                entity.Property(e => e.Gf).HasColumnName("GF");

                entity.HasOne(d => d.FkIdFaseNavigation)
                    .WithMany(p => p.EstadisticasTotalesDelEquipos)
                    .HasForeignKey(d => d.FkIdFase)
                    .HasConstraintName("FK_Estadisticas Totales del Equipo_Fases");

                entity.HasOne(d => d.FkIdPaísNavigation)
                    .WithMany(p => p.EstadisticasTotalesDelEquipos)
                    .HasForeignKey(d => d.FkIdPaís)
                    .HasConstraintName("FK_Estadisticas Totales del Equipo_Países");
            });

            modelBuilder.Entity<EstadoDePartido>(entity =>
            {
                entity.HasKey(e => e.IdEstado)
                    .HasName("PK_EstadoDePartido");

                entity.Property(e => e.IdEstado).HasColumnName("id_estado");

                entity.Property(e => e.Estado)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("estado");
            });

            modelBuilder.Entity<Fase>(entity =>
            {
                entity.HasKey(e => e.IdFase);

                entity.Property(e => e.IdFase)
                    .ValueGeneratedNever()
                    .HasColumnName("id_Fase");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Fgrupo>(entity =>
            {
                entity.HasKey(e => e.IdGrupos)
                    .HasName("PK_Fgrupos");

                entity.ToTable("FGrupos");

                entity.Property(e => e.Grupos)
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Jugadore>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.FkIdClub).HasColumnName("FK_id_club");

                entity.Property(e => e.FkIdPlantilla).HasColumnName("FK_id_plantilla");

                entity.Property(e => e.FkIdPosicion).HasColumnName("FK_id_posicion");

                entity.Property(e => e.Imagen)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Paise>(entity =>
            {
                entity.HasKey(e => e.IdPaises)
                    .HasName("PK_Países");

                entity.Property(e => e.IdPaises).HasColumnName("idPaises");

                entity.Property(e => e.Imagen)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("imagen");

                entity.Property(e => e.Pais)
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Partido>(entity =>
            {
                entity.HasKey(e => e.IdPartido);

                entity.Property(e => e.IdPartido).HasColumnName("id_Partido");

                entity.Property(e => e.FechaHora)
                    .HasColumnType("date")
                    .HasColumnName("Fecha_Hora");

                entity.Property(e => e.FkIdClima).HasColumnName("FK_id_clima");

                entity.Property(e => e.FkIdEstadio).HasColumnName("FK_id_estadio");

                entity.Property(e => e.FkIdEstado).HasColumnName("FK_id_estado");

                entity.Property(e => e.FkIdFase).HasColumnName("FK_id_fase");

                entity.Property(e => e.FkIdPaisA).HasColumnName("FK_id_paisA");

                entity.Property(e => e.FkIdPaisB).HasColumnName("FK_id_paisB");

                entity.HasOne(d => d.FkIdEstadioNavigation)
                    .WithMany(p => p.Partidos)
                    .HasForeignKey(d => d.FkIdEstadio)
                    .HasConstraintName("FK_Partidos_Estadios");

                entity.HasOne(d => d.FkIdFaseNavigation)
                    .WithMany(p => p.Partidos)
                    .HasForeignKey(d => d.FkIdFase)
                    .HasConstraintName("FK_Partidos_Fases");

                entity.HasOne(d => d.FkIdPaisANavigation)
                    .WithMany(p => p.PartidoFkIdPaisANavigations)
                    .HasForeignKey(d => d.FkIdPaisA)
                    .HasConstraintName("FK_Partidos_Países");

                entity.HasOne(d => d.FkIdPaisBNavigation)
                    .WithMany(p => p.PartidoFkIdPaisBNavigations)
                    .HasForeignKey(d => d.FkIdPaisB)
                    .HasConstraintName("FK_Partidos_Países1");
            });

            modelBuilder.Entity<Plantilla>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.FkIdJugador).HasColumnName("FK_id_jugador");

                entity.Property(e => e.FkIdPaís).HasColumnName("FK_id_país");

                entity.HasOne(d => d.FkIdPaísNavigation)
                    .WithMany(p => p.Plantillas)
                    .HasForeignKey(d => d.FkIdPaís)
                    .HasConstraintName("FK_Plantillas_Países");
            });

            modelBuilder.Entity<Posicione>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Posición)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SeleccionesEnGrupo>(entity =>
            {
                entity.HasKey(e => e.IdSeleccionesEnGrupos)
                    .HasName("PK_Selecciones En Grupos");

                entity.Property(e => e.IdSeleccionesEnGrupos)
                    .ValueGeneratedNever()
                    .HasColumnName("idSeleccionesEnGrupos");

                entity.Property(e => e.FkIdFgrupos).HasColumnName("FK_id_Fgrupos");

                entity.Property(e => e.FkIdPaís).HasColumnName("FK_id_país");

                entity.HasOne(d => d.FkIdFgruposNavigation)
                    .WithMany(p => p.SeleccionesEnGrupos)
                    .HasForeignKey(d => d.FkIdFgrupos)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Selecciones En Grupos_Fgrupos");

                entity.HasOne(d => d.FkIdPaísNavigation)
                    .WithMany(p => p.SeleccionesEnGrupos)
                    .HasForeignKey(d => d.FkIdPaís)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Selecciones En Grupos_Países");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
