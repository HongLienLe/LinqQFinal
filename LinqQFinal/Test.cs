using NUnit.Framework;
using System;
using System.Collections.Generic;
using LinqQFinalv;


namespace LinqQFinalTest
{
    [TestFixture]
    public class Test
    {
        private LinqQ _LinqQ; 

        [SetUp]
        public void Setup()
        {
            _LinqQ = new LinqQ();
        }

        [Test]
        public void FindingNumWhereRemainderIsZeroDividedTwo()
        {
            int[] n1 = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var result = _LinqQ.RemainderZeroDividedByTwo(n1);
            var actual = new int[] { 0, 2, 4, 6, 8 };
            Assert.AreEqual(result, actual);

        }
        [Test]
        public void FindingAllThePostiveNoRangingFromOneToEvelen()
        {
            int[] n1 = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };
            var result = _LinqQ.PositiveNum(n1);
            var actual = new int[] { 1, 3, 6, 9, 10};
            Assert.AreEqual(result, actual);

        }
        [Test]
        public void SqrtEachNumInArray()
        {
            int[] n1 = { 9, 8, 5, 6 };
            var result = _LinqQ.SqrtArray(n1);
            var actual = new int[] { 81, 64, 25, 36 };
            Assert.AreEqual(result, actual);

        }
        [Test]
        public void DisplayNumAndFreqInArrString()
        {
            int[] arr1 = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };
            string result = _LinqQ.DisplayNumAndFreqInArr(arr1);
            string expected = "";

            Assert.AreEqual(result,expected); 
        }
       //[Test]
       // public void DisplayCharAndFreq()
       // {
       // }

        [Test]
        public void DisplayDaysOfWeek()
        {
            string expected = "Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday";
            var result = _LinqQ.DisplayWeeksOfDays();

            Assert.That(result.Equals(expected));

        }
        [Test]
        public void DisplayNumFreqMultipled()
        {
            IDictionary<int, int> expected = new Dictionary<int, int>()
            {
                {5,15},
                {1,1},
                {9,9},
            };
        
        }
    }
}
