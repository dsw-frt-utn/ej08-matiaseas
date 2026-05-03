using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    public class Product
    {
        public string _description;

        public Product(string description)
        {
            _description = description;
        }

        public void ChangeDescription(string newDescription)
        {
            _description = newDescription;
        }
    }
}
