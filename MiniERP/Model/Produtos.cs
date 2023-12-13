using System;
using System.Collections.Generic;

namespace MiniERP.Model;

public partial class Produtos
{
    public int Id { get; set; }

    public string? Nome { get; set; }

    public string? Marca { get; set; }

    public decimal? Preco { get; set; }

    public int? FornecedorId { get; set; }

    public virtual Fornecedores? Fornecedor { get; set; }

    public virtual ICollection<NotaFiscalProdutos> NotaFiscalProdutos { get; set; } = new List<NotaFiscalProdutos>();
}
