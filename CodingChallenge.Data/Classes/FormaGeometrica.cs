/*
 * Refactorear la clase para respetar principios de programación orientada a objetos. Qué pasa si debemos soportar un nuevo idioma para los reportes, o
 * agregar más formas geométricas?
 *
 * Se puede hacer cualquier cambio que se crea necesario tanto en el código como en los tests. La única condición es que los tests pasen OK.
 *
 * TODO: Implementar Trapecio/Rectangulo, agregar otro idioma a reporting.
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingChallenge.Data.Classes
{
    public abstract class FormaGeometrica
    {
        #region Formas

        public const int Cuadrado = 1;
        public const int TrianguloEquilatero = 2;
        public const int Circulo = 3;
        public const int Trapecio = 4;

        #endregion

        protected decimal Lado { get; set; }
        protected decimal Base1Trapecio { get; set; }
        protected decimal Base2Trapecio { get; set; }

        public FormaGeometrica(decimal ancho, decimal base1Trapecio = 0, decimal base2Trapecio = 0)
        {
            Lado = ancho;
            Base1Trapecio = base1Trapecio;
            Base2Trapecio = base2Trapecio;
        }

        public static string Imprimir(List<FormaGeometrica> formas, int idioma)
        {
            var sb = new StringBuilder();
            var languageFactory = new LanguageFactory();
            var lang = languageFactory.GetLanguage(idioma);

            if (!formas.Any())
            {
                sb.Append(lang.GetEmptyListText());
            }
            else
            { 
                sb.Append(lang.GetHeaderText());

                var numeroCuadrados = 0;
                var numeroCirculos = 0;
                var numeroTriangulos = 0;
                var numeroTrapecios = 0;

                var areaCuadrados = 0m;
                var areaCirculos = 0m;
                var areaTriangulos = 0m;
                var areaTrapecios = 0m;

                var perimetroCuadrados = 0m;
                var perimetroCirculos = 0m;
                var perimetroTriangulos = 0m;
                var perimetroTrapecios = 0m;

                foreach (var forma in formas)
                {
                    if (forma.GetType() == typeof(Cuadrado))
                    {
                        numeroCuadrados++;
                        areaCuadrados += forma.CalcularArea();
                        perimetroCuadrados += forma.CalcularPerimetro();
                    }
                    if (forma.GetType() == typeof(Circulo))
                    {
                        numeroCirculos++; 
                        areaCirculos += forma.CalcularArea();
                        perimetroCirculos += forma.CalcularPerimetro();
                    }
                    if (forma.GetType() == typeof(Triangulo))
                    {
                        numeroTriangulos++;
                        areaTriangulos += forma.CalcularArea();
                        perimetroTriangulos += forma.CalcularPerimetro();
                    }
                    if (forma.GetType() == typeof(Trapecio))
                    {
                        numeroTrapecios++;
                        areaTrapecios += forma.CalcularArea();
                        perimetroTrapecios += forma.CalcularPerimetro();
                    }
                }

                sb.Append(ObtenerLinea(numeroCuadrados, areaCuadrados, perimetroCuadrados, Cuadrado, lang));
                sb.Append(ObtenerLinea(numeroCirculos, areaCirculos, perimetroCirculos, Circulo, lang));
                sb.Append(ObtenerLinea(numeroTriangulos, areaTriangulos, perimetroTriangulos, TrianguloEquilatero, lang));
                sb.Append(ObtenerLinea(numeroTrapecios, areaTrapecios, perimetroTrapecios, Trapecio, lang));

                // FOOTER
                sb.Append("TOTAL:<br/>");
                sb.Append(numeroCuadrados + numeroCirculos + numeroTriangulos + numeroTrapecios + " " + lang.GetShapeText() + " ");
                sb.Append(lang.GetPerimeterText() + " " + (perimetroCuadrados + perimetroTriangulos + perimetroCirculos + perimetroTrapecios).ToString("#.##") + " ");
                sb.Append("Area " + (areaCuadrados + areaCirculos + areaTriangulos + areaTrapecios).ToString("#.##"));
            }

            return sb.ToString();
        }

        private static string ObtenerLinea(int cantidad, decimal area, decimal perimetro, int tipo, ILanguage lang)
        {
            if (cantidad > 0)
            {
                return lang.GetLineText(cantidad, area, perimetro, tipo);
            }

            return string.Empty;
        }

        public abstract decimal CalcularArea();
        public abstract decimal CalcularPerimetro();
    }
}
