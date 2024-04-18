using System;
using System.Collections.Generic;

namespace TheWitcherEnciclopediaBack.Models;

public partial class HistoriaTrama
{
    public int JuegoId { get; set; }

    public string Titulo { get; set; } = null!;

    public string? Resumen { get; set; }

    public string? EventosClave { get; set; }

    public string? DecisionesImportantes { get; set; }
}
