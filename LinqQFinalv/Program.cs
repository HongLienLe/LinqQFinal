using System;
using System.Linq;

namespace LinqQFinalv
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] arr1 = new int[] { 5, 1, 9, 2, 3, 7, 4, 5, 6, 8, 7, 6, 3, 4, 5, 2 };

            LinqQ test = new LinqQ();
            var newArrZeroDividedByTwo = test.RemainderZeroDividedByTwo(arr1);

            foreach (int num in newArrZeroDividedByTwo)
            {
                Console.WriteLine(num);
            }

        }
    }
}
