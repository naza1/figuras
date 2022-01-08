namespace CodingChallenge.Data.Classes
{
    public class EnglishLang : ILanguage
    {
        public string GetEmptyListText() => "<h1>Empty list of shapes!</h1>";
        public string GetHeaderText() => "<h1>Shapes report</h1>";
        public string GetLineText(int cantidad, decimal area, decimal perimetro, int tipo)
        {
            return $"{cantidad} {GetFormType(tipo, cantidad)} | Area {area:#.##} | Perimeter {perimetro:#.##} <br/>";
        }

        public string GetShapeText() => "shapes";
        public string GetPerimeterText() => "Perimeter";

        private static string GetFormType(int tipo, int cantidad)
        {
            switch (tipo)
            {
                case (int)FormTypeEnum.Cuadrado:
                    return cantidad == 1 ? "Square" : "Squares";
                case (int)FormTypeEnum.Circulo:
                    return cantidad == 1 ? "Circle" : "Circles";
                case (int)FormTypeEnum.TrianguloEquilatero:
                    return cantidad == 1 ? "Triangle" : "Triangles";
            }

            return string.Empty;
        }
    }
}
