using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using MiniERP.Model;

namespace MiniERP;

public partial class MiniErp2Context : DbContext
{
    public MiniErp2Context()
    {
    }

    public MiniErp2Context(DbContextOptions<MiniErp2Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Clientes> Clientes { get; set; }

    public virtual DbSet<Fornecedores> Fornecedores { get; set; }

    public virtual DbSet<NotaFiscalProdutos> NotaFiscalProdutos { get; set; }

    public virtual DbSet<NotasFiscais> NotasFiscais { get; set; }

    public virtual DbSet<Produtos> Produtos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=localhost; initial Catalog=MiniERP2;User ID=MiniERP;password=senha_1234;language=Portuguese;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Clientes>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Clientes__3214EC277436737E");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Bairro)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Cidade)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CpfCnpj)
                .HasMaxLength(14)
                .IsUnicode(false)
                .HasColumnName("CPF_CNPJ");
            entity.Property(e => e.Estado)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NomeRazãoSocial)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("Nome_RazãoSocial");
            entity.Property(e => e.Pais)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Rua)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Telefone)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Fornecedores>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Forneced__3214EC27AF3C9EC7");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Bairro)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Cidade)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CpfCnpj)
                .HasMaxLength(14)
                .IsUnicode(false)
                .HasColumnName("CPF_CNPJ");
            entity.Property(e => e.Estado)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NomeRazãoSocial)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("Nome_RazãoSocial");
            entity.Property(e => e.Pais)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Rua)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Telefone)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<NotaFiscalProdutos>(entity =>
        {
            entity.HasKey(e => new { e.NotaFiscalId, e.ProdutoId }).HasName("PK__NotaFisc__D1E3ECDA2CE75CE7");

            entity.Property(e => e.NotaFiscalId).HasColumnName("NotaFiscalID");
            entity.Property(e => e.ProdutoId).HasColumnName("ProdutoID");
            entity.Property(e => e.PrecoUnitario).HasColumnType("decimal(10, 2)");

            entity.HasOne(d => d.NotaFiscal).WithMany(p => p.NotaFiscalProdutos)
                .HasForeignKey(d => d.NotaFiscalId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__NotaFisca__NotaF__47DBAE45");

            entity.HasOne(d => d.Produto).WithMany(p => p.NotaFiscalProdutos)
                .HasForeignKey(d => d.ProdutoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__NotaFisca__Produ__48CFD27E");
        });

        modelBuilder.Entity<NotasFiscais>(entity =>
        {
            entity.HasKey(e => e.NotaFiscalId).HasName("PK__NotasFis__F82B6CD61F810C6E");

            entity.Property(e => e.NotaFiscalId).HasColumnName("NotaFiscalID");
            entity.Property(e => e.ClienteId).HasColumnName("ClienteID");
            entity.Property(e => e.Data).HasColumnType("datetime");
            entity.Property(e => e.Total).HasColumnType("decimal(10, 2)");

            entity.HasOne(d => d.Cliente).WithMany(p => p.NotasFiscais)
                .HasForeignKey(d => d.ClienteId)
                .HasConstraintName("FK__NotasFisc__Clien__44FF419A");
        });

        modelBuilder.Entity<Produtos>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Produtos__3214EC273FB48A56");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.FornecedorId).HasColumnName("FornecedorID");
            entity.Property(e => e.Marca)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Nome)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Preco).HasColumnType("decimal(10, 2)");

            entity.HasOne(d => d.Fornecedor).WithMany(p => p.Produtos)
                .HasForeignKey(d => d.FornecedorId)
                .HasConstraintName("FK__Produtos__Fornec__398D8EEE");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
