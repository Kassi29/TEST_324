using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace tres.Models;

public partial class TresContext : DbContext
{
    public TresContext()
    {
    }

    public TresContext(DbContextOptions<TresContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Cuentum> Cuenta { get; set; }

    public virtual DbSet<Persona> Personas { get; set; }

    public virtual DbSet<Transaccion> Transaccions { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    { 
    }
/*#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
    => optionsBuilder.UseSqlServer("Server=localhost;Database=tres;Integrated Security=true;TrustServerCertificate=true;");
*/
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cuentum>(entity =>
        {
            entity.HasKey(e => e.Idcuenta).HasName("PK__cuenta__3F3026494CF40F9C");

            entity.ToTable("cuenta");

            entity.Property(e => e.Idcuenta).HasColumnName("idcuenta");
            entity.Property(e => e.Departamento)
                .HasMaxLength(100)
                .HasColumnName("departamento");
            entity.Property(e => e.Fecha)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fecha");
            entity.Property(e => e.Idcliente).HasColumnName("idcliente");
            entity.Property(e => e.Saldo)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("saldo");
            entity.Property(e => e.Tipo)
                .HasMaxLength(20)
                .HasColumnName("tipo");

            entity.HasOne(d => d.IdclienteNavigation).WithMany(p => p.Cuenta)
                .HasForeignKey(d => d.Idcliente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__cuenta__idclient__4222D4EF");
        });

        modelBuilder.Entity<Persona>(entity =>
        {
            entity.HasKey(e => e.Idpersona).HasName("PK__persona__5C5C1E28D2C85B11");

            entity.ToTable("persona");

            entity.Property(e => e.Idpersona).HasColumnName("idpersona");
            entity.Property(e => e.Apellido)
                .HasMaxLength(100)
                .HasColumnName("apellido");
            entity.Property(e => e.Direccion)
                .HasMaxLength(255)
                .HasColumnName("direccion");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasColumnName("nombre");
            entity.Property(e => e.Telefono)
                .HasMaxLength(15)
                .HasColumnName("telefono");
            entity.Property(e => e.Tipo).HasColumnName("tipo");
        });

        modelBuilder.Entity<Transaccion>(entity =>
        {
            entity.HasKey(e => e.Idtransaccion).HasName("PK__transacc__4EA33110E7C7F178");

            entity.ToTable("transaccion");

            entity.Property(e => e.Idtransaccion).HasColumnName("idtransaccion");
            entity.Property(e => e.CuentaDestino).HasColumnName("cuenta_destino");
            entity.Property(e => e.CuentaOrigen).HasColumnName("cuenta_origen");
            entity.Property(e => e.Fecha)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fecha");
            entity.Property(e => e.Monto)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("monto");

            entity.HasOne(d => d.CuentaDestinoNavigation).WithMany(p => p.TransaccionCuentaDestinoNavigations)
                .HasForeignKey(d => d.CuentaDestino)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__transacci__cuent__46E78A0C");

            entity.HasOne(d => d.CuentaOrigenNavigation).WithMany(p => p.TransaccionCuentaOrigenNavigations)
                .HasForeignKey(d => d.CuentaOrigen)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__transacci__cuent__45F365D3");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
