using System;
using System.Collections.Generic;

namespace TheWitcherEnciclopediaBack.Models;

public partial class ArteDiseno
{
    public int ArteId { get; set; }

    public string TipoArte { get; set; } = null!;

    public string? Detalles { get; set; }
}
