using System;
using System.Collections.Generic;

namespace TheWitcherEnciclopediaBack.Models;

public partial class Localizacione
{
    public int LugarId { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }

    public string? Reino { get; set; }
}
