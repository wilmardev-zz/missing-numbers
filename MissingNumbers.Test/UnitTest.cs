using MissingNumbers.BR;
using NUnit.Framework;
using System.Collections.Generic;

namespace Tests
{
    public class UnitTest
    {
        [Test]
        [TestCase(2000000)]
        [TestCase(0)]
        [TestCase(-1)]
        public void DimensionsWrongTest(int number)
        {
            Assert.Catch(() => { InputValidation.ValidateN(number); });
        }

        [Test]
        [TestCase(0, 0)]
        [TestCase(0, -1)]
        [TestCase(-1, -1)]
        [TestCase(0, -1)]
        [TestCase(5, 3)]
        public void ValidateDimensionsTest(int n, int m)
        {
            Assert.Catch(() => { InputValidation.ValidateDimensions(n, m); });
        }

        [Test]
        [TestCase(new string[] { "s", "1" }, 2)]
        [TestCase(new string[] { "s", "s" }, -1)]
        [TestCase(new string[] { "1", "2" }, 3)]
        [TestCase(new string[] { "1", "2", "3" }, 2)]
        public void ValidateArraysTest(string[] array, int dimension)
        {
            Assert.Catch(() => { InputValidation.ValidateArrays(array, dimension); });
        }

        [Test]
        public void ValidateMaxMinTest()
        {
            int[] arrMyValues = new int[] { 10, 20000, 3 };
            List<int> brrList = new List<int>(arrMyValues);
            Assert.Catch(() => { InputValidation.ValidateMaxMin(brrList); });
        }
    }
}