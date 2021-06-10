using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Examen3EV_NS;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PruebaAsignacionCorrectaNotasARA2021()
        {
            List<int> notas = new List<int>();

            notas.Add(0);
            notas.Add(5);
            notas.Add(9);
            notas.Add(3);
            notas.Add(7);
            notas.Add(4);
            notas.Add(8);

            EstadisticasNotasARA2021 estatsNotas = new EstadisticasNotasARA2021(notas);

            double mediaEsperada = 5.143;
            int suspensosEsperados = 3;
            int aprobadosEsperados = 1;
            int notablesEsperados = 2;
            int sobresalientesEsperados = 1;

            Assert.AreEqual(mediaEsperada, estatsNotas.Media, 0.001);
            Assert.AreEqual(suspensosEsperados, estatsNotas.Suspensos);
            Assert.AreEqual(aprobadosEsperados, estatsNotas.Aprobados);
            Assert.AreEqual(notablesEsperados, estatsNotas.Notables);
            Assert.AreEqual(sobresalientesEsperados, estatsNotas.Sobresalientes);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void PruebaListaNotasVacias_DebeDarErrorARA2021()
        {
            List<int> notas = new List<int>();
            
            EstadisticasNotasARA2021 estatsNotas = new EstadisticasNotasARA2021(notas);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void PruebaNotaIncorrecta_DebeDarErrorARA2021()
        {
            List<int> notas = new List<int>();

            notas.Add(0);
            notas.Add(-2);
            notas.Add(9);
            notas.Add(11);

            EstadisticasNotasARA2021 estatsNotas = new EstadisticasNotasARA2021(notas);
        }




    }
}
