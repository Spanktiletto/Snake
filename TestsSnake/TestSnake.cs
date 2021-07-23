using Microsoft.VisualStudio.TestTools.UnitTesting;
using snake_game;
using System.Drawing;

namespace TestsSnakeGame
{
    [TestClass]
    public class TestSnake
    {
        [TestMethod]
        public void PosicionInicialXIsCorrect()
        {
            var snake = new snake();
            Assert.AreEqual<int>(120, snake.x);
        }

        [TestMethod]
        public void PosicionInicialYIsCorrect()
        {
            var snake = new snake();
            Assert.AreEqual<int>(150, snake.y);
        }

        [TestMethod]
        public void HeightInicialIsCorrect()
        {
            var snake = new snake();
            Assert.AreEqual<int>(10, snake.height);
        }

        [TestMethod]
        public void WidthInicialIsCorrect()
        {
            var snake = new snake();
            Assert.AreEqual<int>(10, snake.width);
        }

        [TestMethod]
        public void InitialSnakeSizeIsCorrect()
        {
            var snake = new snake();
            Assert.AreEqual<int>(3, snake.snakeRec.Length);
        }

        [TestMethod]
        public void SnakeInitialRectanglesPosicionAreCorrect()
        {
            var snake = new snake();
            Assert.AreEqual<int>(150, snake.snakeRec[0].X);
            Assert.AreEqual<int>(150, snake.snakeRec[0].Y);
            Assert.AreEqual<int>(140, snake.snakeRec[1].X);
            Assert.AreEqual<int>(150, snake.snakeRec[1].Y);
            Assert.AreEqual<int>(130, snake.snakeRec[2].X);
            Assert.AreEqual<int>(150, snake.snakeRec[2].Y);
        }

        [TestMethod]
        public void SnakeRectanglesSizeAreCorrect()
        {
            var snake = new snake();
            Assert.AreEqual<int>(10, snake.snakeRec[0].Height);
            Assert.AreEqual<int>(10, snake.snakeRec[0].Width);
            Assert.AreEqual<int>(10, snake.snakeRec[1].Height);
            Assert.AreEqual<int>(10, snake.snakeRec[1].Width);
            Assert.AreEqual<int>(10, snake.snakeRec[2].Height);
            Assert.AreEqual<int>(10, snake.snakeRec[2].Width);
        }

        [TestMethod]
        public void SnakeColorIsCorrect()
        {
            var snake = new snake();
            Assert.AreEqual<Color>(Color.Black, snake.pincel.Color);
        }
    }
}


