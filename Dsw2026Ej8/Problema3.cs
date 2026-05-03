using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    public class Problema3
    {
        public string CompararCopias (int originalValue, Product product)
        {
            int copyValue = originalValue;
            copyValue++;

            Product copyProduct = product;
            copyProduct.ChangeDescription("Descripción cambiada");

            return $"{originalValue}-{copyValue}-{product._description}";
        }
    }
}
