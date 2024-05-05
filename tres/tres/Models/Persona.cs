using System;
using System.Collections.Generic;

namespace tres.Models;

public partial class Persona
{
    public int Idpersona { get; set; }

    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public string? Direccion { get; set; }

    public string? Telefono { get; set; }

    public bool? Tipo { get; set; }

    public virtual ICollection<Cuentum> Cuenta { get; set; } = new List<Cuentum>();
}
