using System;
using System.Collections.Generic;

namespace MiniERP.Model;

public partial class Clientes
{
    public int Id { get; set; }

    public string? CpfCnpj { get; set; }

    public string? NomeRazãoSocial { get; set; }

    public string? Telefone { get; set; }

    public string? Pais { get; set; }

    public string? Estado { get; set; }

    public string? Cidade { get; set; }

    public string? Rua { get; set; }

    public int? Numero { get; set; }

    public string? Bairro { get; set; }

    public virtual ICollection<NotasFiscais> NotasFiscais { get; set; } = new List<NotasFiscais>();
}
