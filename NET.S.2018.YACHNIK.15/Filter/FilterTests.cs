using System;
using NUnit.Framework;
using Filter;


namespace FilterTests
{
    [TestFixture]
    public class FilterTests
    {
        [TestCase(new[] { 7, 1, 12, 703, 70 }, ExpectedResult = new[] { 7, 703, 70 })]

        public int[] FilterDelegate_PredicateInt_7(int[] array)
        {
            return array.Filter(x => x.ToString().Contains("7"));
        }

        [Test]
        public void FilterDelegate_PredicateStrings()
        {
            string[] str = { "numbers", "predicate", "numbs", "corn" };
            string[] expected = { "numbers", "numbs" };

            CollectionAssert.AreEqual(str.Filter(x => x.Contains("num")), expected);
        }

        [TestCase(new[] { 7, 1, 12, 703, 70 }, ExpectedResult = new[] { 12, 70 })]

        public int[] FilterInterface_PredicateInt_7(int[] array)
        {
            return array.Filter(new IntegerPredicate());
        }

        [Test]
        public void FilterInterface_PredicateStrings()
        {
            string[] str = { "numbers", "predicate", "nu", "co" };
            string[] expected = { "numbers", "predicate" };

            CollectionAssert.AreEqual(str.Filter(new StringPredicate()), expected);
        }
    }
}
