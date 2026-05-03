using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    public class Problema4
    {
        public double CalcularPromedio(int? nota1, int? nota2, int? nota3)
        {
            int[] notasValidas =
            [
            nota1 ?? int.MinValue,
            nota2 ?? int.MinValue,
            nota3 ?? int.MinValue
            ];

            var filtradas = notasValidas
                .Where(nota => nota >= 0 && nota <= 10)
                .ToArray();

            if (filtradas.Length == 0)
            {
                return 0;
            }

            return filtradas.Average();
        }
    }
}
