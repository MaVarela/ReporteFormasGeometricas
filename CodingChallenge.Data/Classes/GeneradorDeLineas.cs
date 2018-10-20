using System;

namespace CodingChallenge.Data.Classes
{
    /// <summary>
    /// Clase generadora de líneas de texto
    /// </summary>
    public static class GeneradorDeLineas
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
        public static string ObtenerLinea(int cantidad, decimal area, decimal perimetro, string tipo, int idioma)
        {
            if (cantidad > 0)
            {
                var forma = TraducirForma(tipo, cantidad, idioma);
                var mensaje = string.Empty;

                if (idioma == (int)Idiomas.Castellano)
                {
                    mensaje = "{0} " + forma + " | Area {1} | Perimetro {2} <br/>";
                    return string.Format(mensaje, cantidad, area, perimetro);
                }
                else if (idioma == (int)Idiomas.Portugues)
                {
                    mensaje = "{0} " + forma + " | Area {1} | Perimetro {2} <br/>";
                    return string.Format(mensaje, cantidad, area, perimetro);
                }
                else
                {
                    mensaje = "{0} " + forma + " | Area {1} | Perimeter {2} <br/>";
                    return string.Format(mensaje, cantidad, area, perimetro);
                }
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
        public static string TraducirForma(string tipo, int cantidad, int idioma)
        {
            switch (tipo)
            {
                case "Cuadrado":
                    if (idioma == (int)Idiomas.Castellano) return cantidad == 1 ? "Cuadrado" : "Cuadrados";
                    else if(idioma == (int)Idiomas.Portugues) return cantidad == 1 ? "Cuadrado" : "Cuadrados";
                    else return cantidad == 1 ? "Square" : "Squares";
                case "Circulo":
                    if (idioma == (int)Idiomas.Castellano) return cantidad == 1 ? "Círculo" : "Círculos";
                    else if (idioma == (int)Idiomas.Portugues) return cantidad == 1 ? "Círculo" : "Círculos";
                    else return cantidad == 1 ? "Circle" : "Circles";
                case "TrianguloEquilatero":
                    if (idioma == (int)Idiomas.Castellano) return cantidad == 1 ? "Triángulo" : "Triángulos";
                    else if (idioma == (int)Idiomas.Portugues) return cantidad == 1 ? "Triángulo" : "Triángulos";
                    else return cantidad == 1 ? "Triangle" : "Triangles";
                case "Trapecio":
                    if (idioma == (int)Idiomas.Castellano) return cantidad == 1 ? "Trapecio" : "Trapecios";
                    else if (idioma == (int)Idiomas.Portugues) return cantidad == 1 ? "Trapézio" : "Trapézios";
                    else return cantidad == 1 ? "Trapezoid" : "Trapezoids";
                case "Rectangulo":
                    if (idioma == (int)Idiomas.Castellano) return cantidad == 1 ? "Rectángulo" : "Rectángulos";
                    else if (idioma == (int)Idiomas.Portugues) return cantidad == 1 ? "Retângulo" : "Retângulos";
                    else return cantidad == 1 ? "Rectangle" : "Rectangles";
            }

            return string.Empty;
        }

        /// <summary>
        /// Retorna el texto con información de la cantidad de formas geométricas, según el idioma recibido como parámetro
        /// </summary>
        /// <param name="idioma">Idioma</param>
        /// <param name="numeroCuadrados">Número de cuadrados</param>
        /// <param name="numeroCirculos">Número de círculos</param>
        /// <param name="numeroTriangulos">Número de triángulos</param>
        /// <param name="numeroTrapecios">Número de trapecios</param>
        /// <param name="numeroRectangulos">Número de rectángulos</param>
        /// <returns>String</returns>
        public static String CantidadFormas(int idioma, int numeroCuadrados, int numeroCirculos, int numeroTriangulos, int numeroTrapecios, int numeroRectangulos)
        {
            return numeroCuadrados + numeroCirculos + numeroTriangulos + numeroTrapecios + numeroRectangulos + " " + (idioma == (int)Idiomas.Castellano ? "formas" : idioma == (int)Idiomas.Portugues ? "formas " : "shapes") + " ";
        }

        /// <summary>
        /// Retorna el texto con información del perímetro de las formas geométricas, según el idioma recibido como parámetro
        /// </summary>
        /// <param name="idioma">Idioma</param>
        /// <param name="perimetroCuadrados">Perímetro de los cuadrados</param>
        /// <param name="perimetroTriangulos">Perímetro de los triángulos</param>
        /// <param name="perimetroCirculos">Perímetro de los círculos</param>
        /// <param name="perimetroTrapecios">Perímetro de los trapecios</param>
        /// <param name="perimetroRectangulos">Perímetro de los rectángulos</param>
        /// <returns></returns>
        public static String PerimetroTotal(int idioma, decimal perimetroCuadrados, decimal perimetroTriangulos, decimal perimetroCirculos, decimal perimetroTrapecios, decimal perimetroRectangulos)
        {
            return (idioma == (int)Idiomas.Castellano ? "Perimetro " : idioma == (int)Idiomas.Portugues ? "Perimetro " : "Perimeter ") + (perimetroCuadrados + perimetroTriangulos + perimetroCirculos + perimetroTrapecios + perimetroRectangulos).ToString() + " ";
        }

        /// <summary>
        /// Retorna el texto con información del área de las formas geométricas, según el idioma recibido como parámetro
        /// </summary>
        /// <param name="idioma">Idioma</param>
        /// <param name="areaCuadrados">Área de los cuadrados</param>
        /// <param name="areaCirculos">Área de los círculos</param>
        /// <param name="areaTriangulos">Área de los triángulos</param>
        /// <param name="areaTrapecios">Área de los trapecios</param>
        /// <param name="areaRectangulos">Área de los rectángulos</param>
        /// <returns></returns>
        public static String AreaTotal(int idioma, decimal areaCuadrados, decimal areaCirculos, decimal areaTriangulos, decimal areaTrapecios, decimal areaRectangulos)
        {
            return "Area " + (areaCuadrados + areaCirculos + areaTriangulos + areaTrapecios + areaRectangulos).ToString();
        }
    }
}
