using Microsoft.VisualStudio.TestTools.UnitTesting;
using snake_game;

namespace TestsSnake
{
    [TestClass]
    public class TestSnake
    {
        [TestMethod]
        public void PosicionInicialX_120()
        {
            var snake = new snake();
            Assert.AreEqual<int>(120, snake.x);
        }

        [TestMethod]
        public void PosicionInicialY_150()
        {
            var snake = new snake();
            Assert.AreEqual<int>(150, snake.y);
        }

        [TestMethod]
        public void Height_10()
        {
            var snake = new snake();
            Assert.AreEqual<int>(10, snake.height);
        }

        [TestMethod]
        public void Width_10()
        {
            var snake = new snake();
            Assert.AreEqual<int>(10, snake.width);
        }

        [TestMethod]
        public void Dibuja_Serpiente()
        {
            var snake = new snake();

            //Assert.AreEqual<int>(3, snake.snakeRec.Length);
        }
    }
}
