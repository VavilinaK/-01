using System;
using LibraryConvertClass;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Юнит_тест
{
    [TestClass]
    public class UnitTestIsEqualFourThanConverter
    {
        [TestMethod]
        public void IsEqualFourThanConverter1()
        {
            var isEqualFourThanConvert = new IsEqualFourThanConverter();
            object[] values = { 1, 1, 0, 0 };

            var result = isEqualFourThanConvert.Convert(values, typeof(int), null, null);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void IsEqualFourThanConverter2()
        {
            var isEqualFourThanConvert = new IsEqualFourThanConverter();
            object[] values = { 2, 0, 2, 0 };

            var result = isEqualFourThanConvert.Convert(values, typeof(int), null, null);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void IsEqualFourThanConverter3()
        {
            var isEqualFourThanConvert = new IsEqualFourThanConverter();
            object[] values = { 8, 5, 8, 3 };

            var result = isEqualFourThanConvert.Convert(values, typeof(int), null, null);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void IsEqualFourThanConverter4()
        {
            var isEqualFourThanConvert = new IsEqualFourThanConverter();
            object[] values = { 9, 0, 0, 0 };

            var result = isEqualFourThanConvert.Convert(values, typeof(int), null, null);
            Assert.AreEqual(0, result);
        }
    }
}
