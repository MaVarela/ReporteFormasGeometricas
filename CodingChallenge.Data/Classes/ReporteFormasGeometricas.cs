using CodingChallenge.Data.Classes.Contadores;
using CodingChallenge.Data.Classes.GeneradoresDeLineas;
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
            var contadorResolver = new ContadorResolver();
            var contadorCleaner = new ContadorCleaner();
            var generadorDeLineasCuadrado = new GeneradorDeLineasCuadrado();
            var generadorDeLineasCirculo = new GeneradorDeLineasCirculo();
            var generadorDeLineasTrianguloEquilatero = new GeneradorDeLineasTrianguloEquilatero();
            var generadorDeLineasTrapecio = new GeneradorDeLineasTrapecio();
            var generadorDeLineasRectangulo = new GeneradorDeLineasRectangulo();

            if (!formas.Any())
            {
                sb.Append(GeneradorDeLineas.ListaVacia(idioma));
            }
            else
            {
                // Hay por lo menos una forma
                // HEADER
                sb.Append(GeneradorDeLineas.Header(idioma));

                for (var i = 0; i < formas.Count; i++)
                {
                    contadorResolver.SumarFormasGeometricas(formas[i]);
                }

                sb.Append(generadorDeLineasCuadrado.ObtenerLinea(ContadorCuadrados.GetInstance().getCantidad(), ContadorCuadrados.GetInstance().getArea(), ContadorCuadrados.GetInstance().getPerimetro(), typeof(Cuadrado).Name, idioma));
                sb.Append(generadorDeLineasCirculo.ObtenerLinea(ContadorCirculos.GetInstance().getCantidad(), ContadorCirculos.GetInstance().getArea(), ContadorCirculos.GetInstance().getPerimetro(), typeof(Circulo).Name, idioma));
                sb.Append(generadorDeLineasTrianguloEquilatero.ObtenerLinea(ContadorTriangulosEquilateros.GetInstance().getCantidad(), ContadorTriangulosEquilateros.GetInstance().getCantidad(), ContadorTriangulosEquilateros.GetInstance().getPerimetro(), typeof(TrianguloEquilatero).Name, idioma));
                sb.Append(generadorDeLineasTrapecio.ObtenerLinea(ContadorTrapecios.GetInstance().getCantidad(), ContadorTrapecios.GetInstance().getArea(), ContadorTrapecios.GetInstance().getPerimetro(), typeof(Trapecio).Name, idioma));
                sb.Append(generadorDeLineasRectangulo.ObtenerLinea(ContadorRectangulos.GetInstance().getCantidad(), ContadorRectangulos.GetInstance().getArea(), ContadorRectangulos.GetInstance().getPerimetro(), typeof(Rectangulo).Name, idioma));

                // FOOTER
                sb.Append("TOTAL:<br/>");
                sb.Append(GeneradorDeLineas.CantidadFormas(idioma));
                sb.Append(GeneradorDeLineas.PerimetroTotal(idioma));
                sb.Append(GeneradorDeLineas.AreaTotal(idioma));
            }

            contadorCleaner.LimpiarContadores();

            return sb.ToString();
        }
    }
}