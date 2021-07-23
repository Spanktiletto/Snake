using Microsoft.VisualStudio.TestTools.UnitTesting;
using snake_game;
using System.Drawing;
using System;

namespace TestsSnakeGame
{
    [TestClass]
    public class TestComida
    {
        [TestMethod]
        public void PosicionXComidaIsValid()
        {
            Random random = new Random();
            Comida comida = new Comida(random);
            Assert.IsTrue(comida.x < 290 && comida.x > 0);
            Assert.IsTrue(comida.y < 290 && comida.y > 0);
        }
        [TestMethod]
        public void PosicionYComidaIsValid()
        {
            Random random = new Random();
            Comida comida = new Comida(random);
            Assert.IsTrue(comida.y < 290 && comida.y > 0);
        }
        [TestMethod]
        public void RectanglePositionIsCorrect()
        {
            Random random = new Random();
            Comida comida = new Comida(random);
            Assert.IsTrue(comida.x == comida.comidarec.X);
            Assert.IsTrue(comida.y == comida.comidarec.Y);
        }
        [TestMethod]
        public void ComidaColorIsCorrect()
        {
            Random random = new Random();
            Comida comida = new Comida(random);
            Assert.AreEqual<Color>(Color.Red,comida.pincel.Color);
        }

    }
}
