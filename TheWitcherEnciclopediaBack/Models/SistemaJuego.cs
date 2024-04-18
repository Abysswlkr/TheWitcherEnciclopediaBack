using System;
using System.Collections.Generic;

namespace TheWitcherEnciclopediaBack.Models;

public partial class SistemaJuego
{
    public int MecanicaId { get; set; }

    public string Tipo { get; set; } = null!;

    public string? Descripcion { get; set; }
}
