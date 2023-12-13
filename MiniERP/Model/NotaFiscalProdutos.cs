using System;
using System.Collections.Generic;

namespace MiniERP.Model;

public partial class NotaFiscalProdutos
{
    public int NotaFiscalId { get; set; }

    public int ProdutoId { get; set; }

    public int? Quantidade { get; set; }

    public decimal? PrecoUnitario { get; set; }

    public virtual NotasFiscais NotaFiscal { get; set; } = null!;

    public virtual Produtos Produto { get; set; } = null!;
}
