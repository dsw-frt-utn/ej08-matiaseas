using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    public partial class ProductHelper
    {

        public string ObtenerEtiquetaProducto (long _code, string _description, decimal _price)
        {
            return $"[{_code}] {_description} - {FormatearPrecio(_price)}";
        }

    }
}
