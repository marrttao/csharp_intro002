using Microsoft.VisualStudio.TestTools.UnitTesting;
using csharp;
using System.Linq;

namespace csharpTests
{
    [TestClass]
    public class ProgramTests
    {
        private Program _program;

        [TestInitialize]
        public void Setup()
        {
            _program = new Program();
        }

        [TestMethod]
        public void UniqueElements_AllDifferent_ReturnsArrayLength()
        {
            int[] array = { 1, 2, 3, 4, 5 };
            int result = _program.UniqueElements(array);
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void UniqueElements_AllSame_ReturnsZero()
        {
            int[] array = { 7, 7, 7, 7, 7 };
            int result = _program.UniqueElements(array);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void UniqueElements_MixedUniqueAndDuplicates_ReturnsCorrectCount()
        {
            int[] array = { 1, 2, 2, 3, 4, 4, 5 };
            int result = _program.UniqueElements(array);
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void EvenElements_CorrectCount()
        {
            int[] array = { 2, 4, 5, 7, 8 };
            int result = _program.EvenElements(array);
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void OddElements_CorrectCount()
        {
            int[] array = { 2, 4, 5, 7, 8 };
            int result = _program.OddElements(array);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void GetRandomArray_CorrectSize()
        {
            int size = 10;
            int[] result = _program.GetRandomArray(size);
            Assert.AreEqual(size, result.Length);
        }

        [TestMethod]
        public void GetRandomArray_ElementsInRange()
        {
            int size = 20;
            int[] result = _program.GetRandomArray(size);
            bool allInRange = result.All(x => x >= 1 && x < 100);
            Assert.IsTrue(allInRange);
        }
    }
}