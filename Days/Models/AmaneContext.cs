using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Days.Models
{
    public partial class AmaneContext : IdentityDbContext<AplicationUser>
    {
        public AmaneContext()
        {
        }

        public AmaneContext(DbContextOptions<AmaneContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Consejo> Consejos { get; set; }
        public virtual DbSet<ConsejosHabito> ConsejosHabitos { get; set; }
        public virtual DbSet<Habito> Habitos { get; set; }
        public virtual DbSet<HabitosPerfil> HabitosPerfils { get; set; }
        public virtual DbSet<Mensaje> Mensajes { get; set; }
        public virtual DbSet<Perfil> Perfils { get; set; }
        public virtual DbSet<Sala> Salas { get; set; }
        public virtual DbSet<SalaUsuario> SalaUsuarios { get; set; }
        public virtual DbSet<TipoMensaje> TipoMensajes { get; set; }
        public virtual DbSet<TipoSala> TipoSalas { get; set; }
        public virtual DbSet<UsuarioLogin> UsuarioLogins { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=SABEROB-PC\\SQLEXPRESS;Database=Amane;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Consejo>(entity =>
            {
                entity.Property(e => e.ConsejoId).HasColumnName("ConsejoID");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.UsuarioId).HasColumnName("UsuarioID");

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.Consejos)
                    .HasForeignKey(d => d.UsuarioId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__Consejos__Usuari__412EB0B6");
            });

            modelBuilder.Entity<ConsejosHabito>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ConsejoId).HasColumnName("ConsejoID");

                entity.Property(e => e.HabitoId).HasColumnName("HabitoID");

                entity.HasOne(d => d.Consejo)
                    .WithMany(p => p.ConsejosHabitos)
                    .HasForeignKey(d => d.ConsejoId)
                    .HasConstraintName("FK__ConsejosH__Conse__44FF419A");

                entity.HasOne(d => d.Habito)
                    .WithMany(p => p.ConsejosHabitos)
                    .HasForeignKey(d => d.HabitoId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__ConsejosH__Habit__440B1D61");
            });

            modelBuilder.Entity<Habito>(entity =>
            {
                entity.Property(e => e.HabitoId).HasColumnName("HabitoID");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.FechaEntrada).HasColumnType("datetime");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HabitosPerfil>(entity =>
            {
                entity.ToTable("HabitosPerfil");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.HabitoId).HasColumnName("HabitoID");

                entity.Property(e => e.UsuarioId).HasColumnName("UsuarioID");

                entity.HasOne(d => d.Habito)
                    .WithMany(p => p.HabitosPerfils)
                    .HasForeignKey(d => d.HabitoId)
                    .HasConstraintName("FK__HabitosPe__Habit__48CFD27E");

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.HabitosPerfils)
                    .HasForeignKey(d => d.UsuarioId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__HabitosPe__Usuar__47DBAE45");
            });

            modelBuilder.Entity<Mensaje>(entity =>
            {
                entity.Property(e => e.MensajeId).HasColumnName("MensajeID");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Link)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SalaId).HasColumnName("SalaID");

                entity.Property(e => e.TipoId).HasColumnName("TipoID");

                entity.Property(e => e.UsuarioId).HasColumnName("UsuarioID");

                entity.HasOne(d => d.Sala)
                    .WithMany(p => p.Mensajes)
                    .HasForeignKey(d => d.SalaId)
                    .HasConstraintName("FK__Mensajes__SalaID__534D60F1");

                entity.HasOne(d => d.Tipo)
                    .WithMany(p => p.Mensajes)
                    .HasForeignKey(d => d.TipoId)
                    .HasConstraintName("FK__Mensajes__TipoID__5441852A");

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.Mensajes)
                    .HasForeignKey(d => d.UsuarioId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__Mensajes__Usuari__52593CB8");
            });

            modelBuilder.Entity<Perfil>(entity =>
            {
                entity.HasKey(e => e.UsuarioId)
                    .HasName("PK__Perfil__2B3DE79800E1E497");

                entity.ToTable("Perfil");

                entity.Property(e => e.UsuarioId).HasColumnName("UsuarioID");

                entity.Property(e => e.Cumpleaños).HasColumnType("datetime");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Sala>(entity =>
            {
                entity.ToTable("Sala");

                entity.Property(e => e.SalaId).HasColumnName("SalaID");

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.TipoId).HasColumnName("TipoID");

                entity.HasOne(d => d.Tipo)
                    .WithMany(p => p.Salas)
                    .HasForeignKey(d => d.TipoId)
                    .HasConstraintName("FK__Sala__TipoID__4BAC3F29");
            });

            modelBuilder.Entity<SalaUsuario>(entity =>
            {
                entity.ToTable("SalaUsuario");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalaId).HasColumnName("SalaID");

                entity.Property(e => e.UsuarioId).HasColumnName("UsuarioID");

                entity.HasOne(d => d.Sala)
                    .WithMany(p => p.SalaUsuarios)
                    .HasForeignKey(d => d.SalaId)
                    .HasConstraintName("FK__SalaUsuar__SalaI__4E88ABD4");

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.SalaUsuarios)
                    .HasForeignKey(d => d.UsuarioId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__SalaUsuar__Usuar__4F7CD00D");
            });

            modelBuilder.Entity<TipoMensaje>(entity =>
            {
                entity.HasKey(e => e.TipoId)
                    .HasName("PK__TipoMens__97099E97F9283B4E");

                entity.ToTable("TipoMensaje");

                entity.Property(e => e.TipoId).HasColumnName("TipoID");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TipoSala>(entity =>
            {
                entity.HasKey(e => e.TipoId)
                    .HasName("PK__TipoSala__97099E97F7CBAA65");

                entity.ToTable("TipoSala");

                entity.Property(e => e.TipoId).HasColumnName("TipoID");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UsuarioLogin>(entity =>
            {
                entity.HasKey(e => e.LoginId)
                    .HasName("PK__UsuarioL__4DDA283849352750");

                entity.ToTable("UsuarioLogin");

                entity.Property(e => e.LoginId).HasColumnName("LoginID");

                entity.Property(e => e.Contraseña)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioId).HasColumnName("UsuarioID");

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.UsuarioLogins)
                    .HasForeignKey(d => d.UsuarioId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__UsuarioLo__Usuar__3E52440B");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
