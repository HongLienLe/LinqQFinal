using System;
using System.Linq;
using System.Collections.Generic;

namespace LinqQFinalv
{
    public class LinqQ
    {
        List<Students> students = new List<Students> {
            new Students("1","Hong",98),
            new Students("2","Emmanuel",4),
            new Students("3","David", 74),
            new Students("4","Cong", 1),
            new Students("5","Kelly", 2)
            };
        List<string> characters = new List<string> { "m", "n", "o", "p", "q" };



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
            var result = arr1.GroupBy(x => x).Select(group => new { Num = group.Key, Count = group.Count() });
            var output = string.Join(",", result.Select(x => $" Number = {x.Num}, Count = {x.Count}."));
            Console.WriteLine(output);
            return output;
        }

        public string DisplayCharAndFreq()
        {
            var apple = "apple";
            var appleCharArray = apple.ToArray();

            var result = appleCharArray.GroupBy(x => x).Select(grp => new { Char = grp.Key, Count = grp.Count() });
            string output = string.Join("", result.Select(x => $"Character = {x.Char}, Count = {x.Count}."));
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
            int[] arr1 = new int[] { 5, 1, 9, 2, 3, 7, 4, 5, 6, 8, 7, 6, 3, 4, 5, 2 };
            var result = arr1.GroupBy(x => x).Select(x => new { num = x, freq = x.Count(), ans = x.Sum() });
            Console.WriteLine(result);
        }

        public IEnumerable<int> Displaygreaterthan80()
        {
            List<int> nums = new List<int> { 55, 200, 740, 76, 230, 482, 95 };
            var noGreaterThan80 = nums.Where(x => x > 80);
            return noGreaterThan80;
        }

        public IEnumerable<int> TopNthRecord(int v)
        {
            List<int> list = new List<int> { 0 };
            return list;
        }

        public string UpperCaseWordsAre()
        {
            string str = "this IS a STRING";
            string[] arr = str.Split(' ');
            var result = arr.Where(x => x == x.ToUpper()).ToList();
            var upperCaseAre = string.Join("", $"Upper case words are: {result[0]} + {result[1]}");

            return upperCaseAre;
        }

        public string NthMaxGradeIs()
        {

            var sortedList = students.OrderByDescending(x => x.grade).ToList();
            var top3String = string.Join(" ", $"Id: {sortedList[0].id}, Name: {sortedList[0].name}, achieved Grade Point: {sortedList[0].grade} \nId: {sortedList[1].id}, Name: {sortedList[1].name}, achieved Grade Point: {sortedList[1].grade}");
            return top3String;

        }

        public List<string> RemoveCharFromList(List<string> list)
        {

            list.RemoveAt(2);

            return list;

            //public void FileCountByExtensions(
        }

        public List<String> RemoveItemByFilter(List<string> list, string v)
        {
            list.Remove(v);
            return list;
        }

        public List<string> RemovingItemAtIndex(List<string> list,int x)
        {
            list.RemoveAt(x);
            return list;
        }

        public List<string> RemoveARange(List<string> list, int x, int y)
        {
            list.RemoveRange(x, y);
            return list;
        }

        public List<string> FindWordsOfLength(List<string> list, int x)
        {
            var newList = list.Where(y => y.Length <= x).ToList();
            return newList;
        }

        public void InnerJoin(List<ShoppingItems> list)
        {
            Console.WriteLine("Item ID         Item Name       Purchase Quantity                                                             \n");
            Console.WriteLine("-------------------------------------------------------                                                       \n");
            foreach( var thing in list)
            {
                var innerJoin = string.Join("",$"{thing.itemId}               {thing.product}                 {thing.quantity}");
                Console.WriteLine(innerJoin);
            }
        }

        public void DisplayByAscendingOrder(List<string> list)
        {
            string cities = "Rome,London,Nairobi,California,Zurich,New Delhi,Amsterdam,Abu Dhabi,Paris";
            List<string> cityArr = cities.Split(',').ToList();
            var ascendingOrder = cityArr.OrderBy(x => x.Length).ToList();

            foreach (string place in ascendingOrder)
            {
                Console.WriteLine($"{place}");
            }
        }

        public void GroupingFirstThreeCities()
        {
            string cities = "Rome,London,Nairobi,California,Zurich,New Delhi,Amsterdam,Abu Dhabi,Paris";
            List<string> cityArr = cities.Split(',').ToList();

            var grouping = cityArr.GroupBy(x => x).Select(x => new { firstThree = cityArr.Take(3), SecondThree = cityArr.Skip(3).Take(3), last = cities.ElementAt(5) });

            var str = string.Join(" ", grouping.Select(x => $"Group of cities:  {x.firstThree}, Another group of cities:{x.SecondThree} and the last is {x.last}"));
            Console.WriteLine(str);
        }


        public void DisplayStartsAndEndsWithSpecificChar(string start, string end)
        {
            string cities = "Rome,London,Nairobi,California,Zurich,New Delhi,Amsterdam,Abu Dhabi,Paris";
            string[] cityArr = cities.Split(',');
            var result = cityArr.Where(x => x.StartsWith(start)).Where(x => x.EndsWith(end));
            Console.WriteLine(result);
        }



    }
}