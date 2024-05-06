using System;
using System.Collections.Generic;

namespace tres.Models;

public partial class Cuentum
{
    public int Idcuenta { get; set; }

    public string Tipo { get; set; } = null!;

    public decimal Saldo { get; set; }

    public DateTime? Fecha { get; set; }

    public int Idcliente { get; set; }

    public string? Departamento { get; set; }

    public virtual Persona IdclienteNavigation { get; set; } = null!;

    public virtual ICollection<Transaccion> TransaccionCuentaDestinoNavigations { get; set; } = new List<Transaccion>();

    public virtual ICollection<Transaccion> TransaccionCuentaOrigenNavigations { get; set; } = new List<Transaccion>();
}
