using CodingChallenge.Data.Classes.Contadores;
using System;

namespace CodingChallenge.Data.Classes.GeneradoresDeLineas
{
    /// <summary>
    /// Clase generadora de líneas de texto
    /// </summary>
    public abstract class GeneradorDeLineas
    {
        /// <summary>
        /// Retorna el texto para indicar que la lista de formas se encuentra vacía, según el idioma recibido como parámetro
        /// </summary>
        /// <param name="idioma">Idioma</param>
        /// <returns>String</returns>
        public static String ListaVacia(int idioma)
        {
            if (idioma == (int)Idiomas.Castellano)
                return "<h1>Lista vacía de formas!</h1>";
            else if (idioma == (int)Idiomas.Portugues)
                return "<h1>Lista vazia de formas!</h1>";
            else
                return "<h1>Empty list of shapes!</h1>";
        }

        /// <summary>
        /// Retorna el texto para la cabecera del reporte de formas geométricas, según el idioma recibido como parámetro
        /// </summary>
        /// <param name="idioma">Idioma</param>
        /// <returns>String</returns>
        public static String Header(int idioma)
        {
            if (idioma == (int)Idiomas.Castellano)
                return "<h1>Reporte de Formas</h1>";
            else if (idioma == (int)Idiomas.Portugues)
                return "<h1>Relatório de formas!</h1>";
            else
                return "<h1>Shapes report</h1>";
        }

        /// <summary>
        /// Retorna el texto con información de las figuras geométricas, según el idioma recibido como parámetro
        /// </summary>
        /// <param name="idioma">Idioma</param>
        /// <param name="area">Área de las figuras</param>
        /// <param name="perimetro">Perímetro de las figuras</param>
        /// <param name="tipo">Nombre de la figura</param>
        /// <param name="cantidad">Cantidad de figuras</param>
        /// <returns>String</returns>
        public abstract string ObtenerLinea(int cantidad, decimal area, decimal perimetro, string tipo, int idioma);

        /// <summary>
        /// Retorna el nombre de una forma geométrica, según el idioma recibido como parámetro
        /// </summary>
        /// <param name="idioma">Idioma</param>
        /// <param name="tipo">Nombre de la figura</param>
        /// <param name="cantidad">Cantidad de figuras</param>
        /// <returns>String</returns>
        public abstract string TraducirForma(string tipo, int cantidad, int idioma);


        /// <summary>
        /// Retorna el texto con información de las figuras geométricas, según el idioma recibido como parámetro
        /// </summary>
        /// <param name="idioma">Idioma</param>
        /// <param name="forma">Nombre de la figura</param>
        /// <param name="contador">Contador de figuras</param>
        /// <returns>String</returns>
        protected string GenerarLinea(IContadorFormaGeometrica contador, int idioma, string forma)
        {
            string mensaje = string.Empty;
            
            if (idioma == (int)Idiomas.Castellano)
            {
                mensaje = "{0} " + forma + " | Area {1} | Perimetro {2} <br/>";
                return string.Format(mensaje, contador.getCantidad(), contador.getArea(), contador.getPerimetro());
            }
            else if (idioma == (int)Idiomas.Portugues)
            {
                mensaje = "{0} " + forma + " | Area {1} | Perimetro {2} <br/>";
                return string.Format(mensaje, contador.getCantidad(), contador.getArea(), contador.getPerimetro());
            }
            else
            {
                mensaje = "{0} " + forma + " | Area {1} | Perimeter {2} <br/>";
                return string.Format(mensaje, contador.getCantidad(), contador.getArea(), contador.getPerimetro());
            }
        }

        /// <summary>
        /// Retorna el texto con información de la cantidad de formas geométricas, según el idioma recibido como parámetro
        /// </summary>
        /// <param name="idioma">Idioma</param>
        /// <returns>String</returns>
        public static String CantidadFormas(int idioma)
        {
            return CalculadorCantidadFormas.CalcularTotal() + " " + (idioma == (int)Idiomas.Castellano ? "formas" : idioma == (int)Idiomas.Portugues ? "formas " : "shapes") + " ";
        }

        /// <summary>
        /// Retorna el texto con información del perímetro de las formas geométricas, según el idioma recibido como parámetro
        /// </summary>
        /// <param name="idioma">Idioma</param>
        /// <returns>String</returns>
        public static String PerimetroTotal(int idioma)
        {
            return (idioma == (int)Idiomas.Castellano ? "Perimetro " : idioma == (int)Idiomas.Portugues ? "Perimetro " : "Perimeter ") + (CalculadorPerimetroTotal.CalcularPerimetroTotal()).ToString() + " ";
        }

        /// <summary>
        /// Retorna el texto con información del área de las formas geométricas, según el idioma recibido como parámetro
        /// </summary>
        /// <param name="idioma">Idioma</param>
        /// <returns>String</returns>
        public static String AreaTotal(int idioma)
        {
            return "Area " + (CalculadorAreaTotal.CalcularAreaTotal()).ToString();
        }
    }
}
