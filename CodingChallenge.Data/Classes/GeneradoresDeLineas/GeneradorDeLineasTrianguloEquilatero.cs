﻿using CodingChallenge.Data.Classes.Contadores;
using CodingChallenge.Data.Classes.Reporte;

namespace CodingChallenge.Data.Classes.GeneradoresDeLineas
{
    /// <summary>
    /// Clase generadora de líneas de texto para los triángulos equilateros
    /// </summary>
    public class GeneradorDeLineasTrianguloEquilatero : GeneradorDeLineas
    {
        /// <summary>
        /// Retorna el texto con información de las figuras geométricas, según el idioma recibido como parámetro
        /// </summary>
        /// <param name="idioma">Idioma</param>
        /// <param name="area">Área de las figuras</param>
        /// <param name="perimetro">Perímetro de las figuras</param>
        /// <param name="tipo">Nombre de la figura</param>
        /// <param name="cantidad">Cantidad de figuras</param>
        /// <returns>String</returns>
        public override string ObtenerLinea(int cantidad, decimal area, decimal perimetro, string tipo, int idioma)
        {
            var contadorResolver = new ContadorResolver();

            var contador = contadorResolver.GetContador(tipo) as ContadorTriangulosEquilateros;

            if (contador.getCantidad() > 0)
            {
                var forma = TraducirForma(tipo, contador.getCantidad(), idioma);

                return this.GenerarLinea(contador, idioma, forma);
            }

            return string.Empty;
        }

        /// <summary>
        /// Retorna el nombre de una forma geométrica, según el idioma recibido como parámetro
        /// </summary>
        /// <param name="idioma">Idioma</param>
        /// <param name="tipo">Nombre de la figura</param>
        /// <param name="cantidad">Cantidad de figuras</param>
        /// <returns>String</returns>
        public override string TraducirForma(string tipo, int cantidad, int idioma)
        {
            if (idioma == (int)Idiomas.Castellano) return cantidad == 1 ? "Triángulo" : "Triángulos";
            else if (idioma == (int)Idiomas.Portugues) return cantidad == 1 ? "Triángulo" : "Triángulos";
            else return cantidad == 1 ? "Triangle" : "Triangles";
        }
    }
}
