using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    public class Problema2
    {
        public string CrearResumenVenta(long _productCode, string _productDescription, int _quantity, decimal _unitPrice)
        {
            var venta = new {
                Code = _productCode,
                Description = _productDescription,
                Quantity = _quantity,
                Total = _quantity > 0 ? _quantity * _unitPrice : 0
            };

            return $"{venta.Code} - {venta.Description} - {venta.Total:C}";
        }
    }
}
