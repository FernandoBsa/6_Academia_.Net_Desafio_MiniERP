using System;
using System.Collections.Generic;

namespace MiniERP.Model;

public partial class NotasFiscais
{
    public int NotaFiscalId { get; set; }

    public int? ClienteId { get; set; }

    public DateTime? Data { get; set; }

    public decimal? Total { get; set; }

    public virtual Clientes? Cliente { get; set; }

    public virtual ICollection<NotaFiscalProdutos> NotaFiscalProdutos { get; set; } = new List<NotaFiscalProdutos>();
}
