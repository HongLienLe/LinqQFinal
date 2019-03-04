using System;
using System.Linq;
using System.Collections.Generic;

namespace LinqQFinalv
{
    public class LinqQ
    {
        public int[] RemainderZeroDividedByTwo(int[] arr)
        {
            return arr.Where(x => x % 2 == 0).ToArray();
        }

        public int[] PositiveNum(int[] arr)
        {
            return arr.Where(x => x > 0 && x < 12).ToArray();
        }

        public int[] SqrtArray(int[] arr)
        {
            return arr.Select(x => x * x).ToArray();
        }

        public string DisplayNumAndFreqInArr(int[] arr1)
        {
            var result = arr1.GroupBy(x => x).Select(group => new { Num = group.Key, Count = group.Count()});
            var output = string.Join(",", result.Select(x => $" Number = {x.Num}, Count = {x.Count}."));
            Console.WriteLine(output);
            return output;
        }

        public string DisplayCharAndFreq()
        {
            var apple = "apple";
            var appleCharArray = apple.ToArray();

            var result = appleCharArray.GroupBy(x => x).Select(grp => new { Char = grp.Key, Count= grp.Count() });
            string output = string.Join("", result.Select(x => $" Character = {x.Char}, Count = {x.Count}."));
            Console.WriteLine(output);

            return output;
        }

        public string DisplayWeeksOfDays()
        {
            string[] daysOfWeek = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            var output = string.Join(", ", daysOfWeek);
            Console.WriteLine(output);

            return output;
        }
        public void DisplayNumMultiOfNumWithFreq()
        {
            List<int> list;
            int[] arr1 = new int[] { 5, 1, 9, 2, 3, 7, 4, 5, 6, 8, 7, 6, 3, 4, 5, 2 };
            var result = arr1.GroupBy(x => x).Select(x => new { num = x, freq = x.Count(), ans = x.Sum()});

        }
        public void DisplayStartsAndEndsWithSpecificChar(char start, char end)
        {

        }
    }
}