using System.Collections.Generic;
using CodingChallenge.Data.Classes;
using NUnit.Framework;
using CodingChallenge.Data.Classes.Reporte;

namespace CodingChallenge.Data.Tests
{
    [TestFixture]
    public class DataTests
    {
        [TestCase]
        public void TestResumenListaVacia()
        {
            Assert.AreEqual("<h1>Lista vacía de formas!</h1>",
                ReporteFormasGeometricas.Imprimir(new List<FormaGeometrica>(), (int)Idiomas.Castellano));
        }

        [TestCase]
        public void TestResumenListaVaciaFormasEnIngles()
        {
            Assert.AreEqual("<h1>Empty list of shapes!</h1>",
                ReporteFormasGeometricas.Imprimir(new List<FormaGeometrica>(), (int)Idiomas.Ingles));
        }

        [TestCase]
        public void TestResumenListaVaciaFormasEnPortuges()
        {
            Assert.AreEqual("<h1>Lista vazia de formas!</h1>",
                ReporteFormasGeometricas.Imprimir(new List<FormaGeometrica>(), (int)Idiomas.Portugues));
        }

        [TestCase]
        public void TestResumenListaConUnCuadrado()
        {
            var cuadrados = new List<FormaGeometrica> {new Cuadrado(5)};

            var resumen = ReporteFormasGeometricas.Imprimir(cuadrados, (int)Idiomas.Castellano);

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Cuadrado | Area 25 | Perimetro 20 <br/>TOTAL:<br/>1 formas Perimetro 20 Area 25", resumen);
        }

        [TestCase]
        public void TestResumenListaConUnTrapecio()
        {
            var cuadrados = new List<FormaGeometrica> { new Trapecio(8, 4, 5, 3, 3) };

            var resumen = ReporteFormasGeometricas.Imprimir(cuadrados, (int)Idiomas.Castellano);

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Trapecio | Area 30 | Perimetro 18 <br/>TOTAL:<br/>1 formas Perimetro 18 Area 30", resumen);
        }

        [TestCase]
        public void TestResumenListaConUnRectangulo()
        {
            var cuadrados = new List<FormaGeometrica> { new Rectangulo(4, 2) };

            var resumen = ReporteFormasGeometricas.Imprimir(cuadrados, (int)Idiomas.Castellano);

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Rectángulo | Area 8 | Perimetro 12 <br/>TOTAL:<br/>1 formas Perimetro 12 Area 8", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasCuadrados()
        {
            var cuadrados = new List<FormaGeometrica>
            {
                new Cuadrado(5),
                new Cuadrado(1),
                new Cuadrado(3)
            };

            var resumen = ReporteFormasGeometricas.Imprimir(cuadrados, (int)Idiomas.Ingles);

            Assert.AreEqual("<h1>Shapes report</h1>3 Squares | Area 35 | Perimeter 36 <br/>TOTAL:<br/>3 shapes Perimeter 36 Area 35", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTipos()
        {
            var formas = new List<FormaGeometrica>
            {
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new TrianguloEquilatero(9),
                new Circulo(2.75m),
                new TrianguloEquilatero(4.2m),
                new Trapecio(8, 3, 5, 4, 4),
                new Rectangulo(6, 2)
            };

            var resumen = ReporteFormasGeometricas.Imprimir(formas, (int)Idiomas.Ingles);

            Assert.AreEqual(
                "<h1>Shapes report</h1>2 Squares | Area 29 | Perimeter 28 <br/>2 Circles | Area 13,01 | Perimeter 18,06 <br/>3 Triangles | Area 49,64 | Perimeter 51,6 <br/>1 Trapezoid | Area 27,5 | Perimeter 19 <br/>1 Rectangle | Area 12 | Perimeter 16 <br/>TOTAL:<br/>9 shapes Perimeter 132,66 Area 131,15",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTiposPortuges()
        {
            var formas = new List<FormaGeometrica>
            {
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new TrianguloEquilatero(9),
                new Circulo(2.75m),
                new TrianguloEquilatero(4.2m),
                new Trapecio(8, 3, 5, 4, 4),
                new Rectangulo(6, 2)
            };

            var resumen = ReporteFormasGeometricas.Imprimir(formas, (int)Idiomas.Portugues);

            Assert.AreEqual(
                "<h1>Relatório de formas!</h1>2 Cuadrados | Area 29 | Perimetro 28 <br/>2 Círculos | Area 13,01 | Perimetro 18,06 <br/>3 Triángulos | Area 49,64 | Perimetro 51,6 <br/>1 Trapézio | Area 27,5 | Perimetro 19 <br/>1 Retângulo | Area 12 | Perimetro 16 <br/>TOTAL:<br/>9 formas  Perimetro 132,66 Area 131,15",
                resumen);

            
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnCastellano()
        {
            var formas = new List<FormaGeometrica>
            {
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new TrianguloEquilatero(9),
                new Circulo(2.75m),
                new TrianguloEquilatero(4.2m)
            };

            var resumen = ReporteFormasGeometricas.Imprimir(formas, (int)Idiomas.Castellano);

            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>2 Cuadrados | Area 29 | Perimetro 28 <br/>2 Círculos | Area 13,01 | Perimetro 18,06 <br/>3 Triángulos | Area 49,64 | Perimetro 51,6 <br/>TOTAL:<br/>7 formas Perimetro 97,66 Area 91,65",
                resumen);
        }
    }
}
