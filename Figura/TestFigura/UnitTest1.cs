using Figura;
using NUnit.Framework;
using System;

namespace TestFigura
{
    public class Tests
    {
        Figuras figura;
        [SetUp]
        public void Setup()
        {
           
        }

        [Test]
        public void CalcularAreaCirculo()
        {
            var area= Math.PI * (Math.Exp(4));
            figura = new Circulo(4);
           
            Assert.AreEqual("El area del circulo es: "+area, figura.MostrarArea());
        }
        
        [Test]
        public void CalcularAreaCuadrado()
        {
            var area= 10*20;
            figura = new Rectangulo(10,20);         
            Assert.AreEqual("El area del rectangulo es: " + area, figura.MostrarArea());
        }
    }
}