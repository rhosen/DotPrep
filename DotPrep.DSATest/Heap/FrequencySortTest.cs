using DotPrep.DSA.Heap;
using System.Collections.Generic;
using Xunit;

namespace DotPrep.DSATest.Heap
{
    public class FrequencySortTest
    {

        FrequencySort _frequencySort;

        public FrequencySortTest()
        {
            _frequencySort = new FrequencySort();
        }

        [Fact]
        public void Test1()
        {
            var set = new List<string> { "eert", "eetr" };
            var s = "tree";
            var actual = _frequencySort.SortCharactersByFrequency(s);
            Assert.Contains(actual, set);
        }

        [Fact]
        public void Test2()
        {
            var set = new List<string> { "aaaccc", "cccaaa" };
            var s = "cccaaa";
            var actual = _frequencySort.SortCharactersByFrequency(s);
            Assert.Contains(actual, set);
        }

        [Fact]
        public void Test3()
        {
            var set = new List<string> { "bbAa", "bbaA" };
            var s = "Aabb";
            var actual = _frequencySort.SortCharactersByFrequency(s);
            Assert.Contains(actual, set);
        }
    }
}
