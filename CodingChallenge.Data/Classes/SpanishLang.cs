namespace CodingChallenge.Data.Classes
{
    public class SpanishLang : ILanguage
    {
        public string GetEmptyListText() => "<h1>Lista vacía de formas!</h1>";
        public string GetHeaderText() => "<h1>Reporte de Formas</h1>";
        public string GetLineText(int cantidad, decimal area, decimal perimetro, int tipo)
        {
            return $"{cantidad} {GetFormType(tipo, cantidad)} | Area {area:#.##} | Perimetro {perimetro:#.##} <br/>";
        }

        public string GetShapeText() => "formas";

        public string GetPerimeterText() => "Perimetro";

        private static string GetFormType(int tipo, int cantidad)
        {
            switch (tipo)
            {
                case (int)FormTypeEnum.Cuadrado:
                    return cantidad == 1 ? "Cuadrado" : "Cuadrados";
                case (int)FormTypeEnum.Circulo:
                    return cantidad == 1 ? "Círculo" : "Círculos";
                case (int)FormTypeEnum.TrianguloEquilatero:
                    return cantidad == 1 ? "Triángulo" : "Triángulos";
            }

            return string.Empty;
        }
    }
}
