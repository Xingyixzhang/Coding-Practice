using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testing
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] stones = new int[] { 2, 7, 4, 1, 8, 1 };
            Console.WriteLine(LastStoneWeight(stones));
            Console.Read();
        }
        public static int LastStoneWeight(int[] stones)
        {
            if (stones.Length == 1) return stones[0];
            if (stones.Length == 2) return Math.Abs(stones[0] - stones[1]);
            var temp = new List<int>();
            Array.Sort(stones); int i = 0;
            foreach (int num in stones) temp.Add(num);
            int len = temp.Count;
            while (len > 1)
            {
                if (temp[len - 1] == temp[len - 2])
                    temp.RemoveRange(len - 2, 2);
                else
                {
                    int newVal = Math.Abs(temp[len - 1] - temp[len - 2]);
                    temp.RemoveRange(len - 2, 2);
                    temp.Add(newVal);
                    temp.Sort();
                }
                len = temp.Count;
            }
            if (len == 1) return temp[0];
            else return 0;
        }
    }
}
