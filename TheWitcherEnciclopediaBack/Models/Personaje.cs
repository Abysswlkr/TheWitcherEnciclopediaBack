using System;
using System.Collections.Generic;

namespace TheWitcherEnciclopediaBack.Models;

public partial class Personaje
{
    public int PersonajeId { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }

    public string? Habilidades { get; set; }

    public string? Relaciones { get; set; }
}
