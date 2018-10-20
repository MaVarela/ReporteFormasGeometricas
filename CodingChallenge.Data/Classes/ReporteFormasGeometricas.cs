using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingChallenge.Data.Classes
{
    /// <summary>
    /// Clase generadora de reporte de formas geométricas
    /// </summary>
    public static class ReporteFormasGeometricas
    {
        /// <summary>
        /// Realiza la impresión del reporte de formas geométricas, según el idioma recibido por parámetro
        /// </summary>
        /// <param name="formas">Lista de formas geométricas</param>
        /// <param name="idioma">Idioma</param>
        /// <returns>String</returns>
        public static string Imprimir(List<FormaGeometrica> formas, int idioma)
        {
            var sb = new StringBuilder();

            if (!formas.Any())
            {
                sb.Append(GeneradorDeLineas.ListaVacia(idioma));
            }
            else
            {
                // Hay por lo menos una forma
                // HEADER
                sb.Append(GeneradorDeLineas.Header(idioma));

                var numeroCuadrados = 0;
                var numeroCirculos = 0;
                var numeroTriangulos = 0;
                var numeroTrapecios = 0;
                var numeroRectangulos = 0;

                var areaCuadrados = 0m;
                var areaCirculos = 0m;
                var areaTriangulos = 0m;
                var areaTrapecios = 0m;
                var areaRectangulos = 0m;

                var perimetroCuadrados = 0m;
                var perimetroCirculos = 0m;
                var perimetroTriangulos = 0m;
                var perimetroTrapecios = 0m;
                var perimetroRectangulos = 0m;

                for (var i = 0; i < formas.Count; i++)
                {
                    if (formas[i].GetType() == typeof(Cuadrado))
                    {
                        numeroCuadrados++;
                        areaCuadrados += formas[i].CalcularArea();
                        perimetroCuadrados += formas[i].CalcularPerimetro();
                    }
                    if (formas[i].GetType() == typeof(Circulo))
                    {
                        numeroCirculos++;
                        areaCirculos += formas[i].CalcularArea();
                        perimetroCirculos += formas[i].CalcularPerimetro();
                    }
                    if (formas[i].GetType() == typeof(TrianguloEquilatero))
                    {
                        numeroTriangulos++;
                        areaTriangulos += formas[i].CalcularArea();
                        perimetroTriangulos += formas[i].CalcularPerimetro();
                    }
                    if (formas[i].GetType() == typeof(Trapecio))
                    {
                        numeroTrapecios++;
                        areaTrapecios += formas[i].CalcularArea();
                        perimetroTrapecios += formas[i].CalcularPerimetro();
                    }
                    if (formas[i].GetType() == typeof(Rectangulo))
                    {
                        numeroRectangulos++;
                        areaRectangulos += formas[i].CalcularArea();
                        perimetroRectangulos += formas[i].CalcularPerimetro();
                    }
                }

                sb.Append(GeneradorDeLineas.ObtenerLinea(numeroCuadrados, areaCuadrados, perimetroCuadrados, typeof(Cuadrado).Name, idioma));
                sb.Append(GeneradorDeLineas.ObtenerLinea(numeroCirculos, areaCirculos, perimetroCirculos, typeof(Circulo).Name, idioma));
                sb.Append(GeneradorDeLineas.ObtenerLinea(numeroTriangulos, areaTriangulos, perimetroTriangulos, typeof(TrianguloEquilatero).Name, idioma));
                sb.Append(GeneradorDeLineas.ObtenerLinea(numeroTrapecios, areaTrapecios, perimetroTrapecios, typeof(Trapecio).Name, idioma));
                sb.Append(GeneradorDeLineas.ObtenerLinea(numeroRectangulos, areaRectangulos, perimetroRectangulos, typeof(Rectangulo).Name, idioma));

                // FOOTER
                sb.Append("TOTAL:<br/>");
                sb.Append(GeneradorDeLineas.CantidadFormas(idioma, numeroCuadrados, numeroCirculos, numeroTriangulos, numeroTrapecios, numeroRectangulos));
                sb.Append(GeneradorDeLineas.PerimetroTotal(idioma, perimetroCuadrados, perimetroTriangulos, perimetroCirculos, perimetroTrapecios, perimetroRectangulos));
                sb.Append(GeneradorDeLineas.AreaTotal(idioma, areaCuadrados, areaCirculos, areaTriangulos, areaTrapecios, areaRectangulos));
            }

            return sb.ToString();
        }
    }
}