namespace CodingChallenge.Data.Classes
{
    public class Cuadrado : FormaGeometrica
    {
        public override decimal CalcularArea() => Lado * Lado;

        public override decimal CalcularPerimetro() => Lado * 4;

        public Cuadrado(int tipo, decimal ancho) : base(ancho)
        {
        }
    }
}
