using System;
using System.Collections.Generic;

namespace TheWitcherEnciclopediaBack.Models;

public partial class Bestiario
{
    public int MonstruoId { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Debilidades { get; set; }

    public string? TacticasCombate { get; set; }
}
