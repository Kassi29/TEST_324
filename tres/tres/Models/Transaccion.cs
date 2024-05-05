using System;
using System.Collections.Generic;

namespace tres.Models;

public partial class Transaccion
{
    public int Idtransaccion { get; set; }

    public int CuentaOrigen { get; set; }

    public int CuentaDestino { get; set; }

    public decimal Monto { get; set; }

    public DateTime? Fecha { get; set; }

    public virtual Cuentum CuentaDestinoNavigation { get; set; } = null!;

    public virtual Cuentum CuentaOrigenNavigation { get; set; } = null!;
}
