using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public class Trapecio : FormaGeometrica
    {
        public Trapecio(decimal ancho) : base(ancho)
        {
        }

        public override decimal CalcularArea()
        {
            return ((Base1Trapecio + Base2Trapecio) * Lado) / 2;
        }

        public override decimal CalcularPerimetro()
        {
            return Base1Trapecio + Base2Trapecio + 2 * Lado;
        }
    }
}
