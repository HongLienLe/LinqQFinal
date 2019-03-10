using NUnit.Framework;
using System;
using System.Text;
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
        public void DisplayDaysOfWeek()
        {
            string expected = "Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday";
            var result = _LinqQ.DisplayWeeksOfDays();

            Assert.That(result.Equals(expected));

        }
        [Test]
        public void GetNumberGreaterThan80()
        {
            IEnumerable<int> somenumbers = new int[] { 200, 740, 76, 230, 482, 95 };
            var result = _LinqQ.Displaygreaterthan80();
            Assert.That(result.Equals(somenumbers));
        }
        [Test]
        public void DisplayTopNthRecord()
        {
            string expected = "Top 3 records from the list is are: 24, 13, 9.";
            var result = _LinqQ.TopNthRecord(3);

            Assert.That(expected.Equals(result));
        }
        [Test]
        public void FindUpperCaseWordsInArray()
        {
            var expected = "Upper case words are: IS + STRING";
            var result = _LinqQ.UpperCaseWordsAre();

            Assert.That(expected.Equals(result));
        }
        [Test]
        public void FindThenthMaxGrade()
        {
            var expected = "Id: 1, Name: Hong, achieved Grade Point: 98 \nId: 3, Name: David, achieved Grade Point: 74";
            var result = _LinqQ.NthMaxGradeIs();
            Assert.That(expected.Equals(result));
        }
        //[Test]
        //public void CountingFileExtensionsAndGroupIt()
        //{
        //    var expected = "Here is the group of extension of the files : \n1 File(s) with .frx Extension \n3 File(s) with .txt Extension \n1 File(s) with .dbf Extension \n2 File(s) with .pdf Extension \n1 File(s) with .frt Extension \n1 File(s) with .xml Extension";
        //    var result = _LinqQ.FileCountByExtensions();

        //    Assert.That(expected.Equals(result));

        //}
        [Test]
        public void CanRemoveItemFromList()
        {
            var expected = new List<string> {"m", "n", "p", "q"};
            List<string> result = _LinqQ.RemoveCharFromList();
            Assert.That(expected.Equals(result));
        }
        [Test]
        public void CanRemoveItemByFilter()
        {
            var expected = new List<string> { "m", "n", "o", "q" };
            var result = _LinqQ.RemoveItemByFilter("q");
            Assert.That(expected.Equals(result));
        }
    }
}
