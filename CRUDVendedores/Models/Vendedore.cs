using System;
using System.Collections.Generic;

namespace CRUDVendedores.Models;

public partial class Vendedore
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public decimal? PorcentajeComision { get; set; }

    public string? Estado { get; set; }
}
