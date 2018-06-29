using System;
using NUnit.Framework;

namespace ArrayExtension.nUnit.Test
{
    [TestFixture]
    public class ArrayExtensionNunitTests
    {
        [TestCase(new int[] { 9, 3, 31, 56, 77, 23, 7, 17, 242 }, 7, ExpectedResult = new int[] { 77, 7, 17 })]
        public int[] FilterArrayDigitNUnit(int[] source, int digit) => ArrayExtensions.ArrayExtensions.FilterNumbers(source, digit);

        [Test]
        public void FilterDigitNullArrayNUnit()
            => Assert.Throws<ArgumentNullException>(() => ArrayExtensions.ArrayExtensions.FilterNumbers(null, 7));

        [Test]
        public void FilterDigitZeroArrayNUnit()
            => Assert.Throws<ArgumentException>(() => ArrayExtensions.ArrayExtensions.FilterNumbers(new int[] { }, 7));

        [Test]
        public void FilterDigitOutOfRangeNUnit()
            => Assert.Throws<ArgumentOutOfRangeException>(() => ArrayExtensions.ArrayExtensions.FilterNumbers(new int[] {10, 1}, 70));



    }
}
