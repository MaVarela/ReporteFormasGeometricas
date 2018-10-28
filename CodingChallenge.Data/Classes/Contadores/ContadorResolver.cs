using System;

namespace CodingChallenge.Data.Classes.Contadores
{
    /// <summary>
    /// Contador Resolver
    /// </summary>
    public class ContadorResolver
    {
        private const String _circulo = "Circulo";
        private const String _trianguloEquilatero = "TrianguloEquilatero";
        private const String _cuadrado = "Cuadrado";
        private const String _rectangulo = "Rectangulo";
        private const String _trapecio = "Trapecio";

        /// <summary>
        /// Se encarga de realizar la suma de área, perímetro y cantidad de forma geométrica según la forma que corresponda
        /// </summary>
        /// <param name="forma">Forma geométrica</param>
        public void SumarFormasGeometricas(FormaGeometrica forma)
        {
            switch (forma.GetType().Name)
            {
                case _circulo:
                    ContadorCirculos.GetInstance().SumarFormaGeometrica(forma);
                    break;
                case _trianguloEquilatero:
                    ContadorTriangulosEquilateros.GetInstance().SumarFormaGeometrica(forma);
                    break;
                case _cuadrado:
                    ContadorCuadrados.GetInstance().SumarFormaGeometrica(forma);
                    break;
                case _rectangulo:
                    ContadorRectangulos.GetInstance().SumarFormaGeometrica(forma);
                    break;
                case _trapecio:
                    ContadorTrapecios.GetInstance().SumarFormaGeometrica(forma);
                    break;
            }
        }

        /// <summary>
        /// Retorna el contador correspondiente según la forma geométrica
        /// </summary>
        /// <param name="forma">Forma geométrica</param>
        /// <returns>IContadorFormaGeometrica</returns>
        public IContadorFormaGeometrica GetContador(String forma)
        {
            IContadorFormaGeometrica result = null;

            switch (forma)
            {
                case _circulo:
                    result = ContadorCirculos.GetInstance();
                    break;
                case _trianguloEquilatero:
                    result = ContadorTriangulosEquilateros.GetInstance();
                    break;
                case _cuadrado:
                    result = ContadorCuadrados.GetInstance();
                    break;
                case _rectangulo:
                    result = ContadorRectangulos.GetInstance();
                    break;
                case _trapecio:
                    result = ContadorTrapecios.GetInstance();
                    break;
            }

            return result;
        }
    }
}
