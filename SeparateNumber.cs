using System;
namespace RecursionNum
{
    class Program
    {
        static void Main(string[] args)
        {
            numSep(231);
        }
        public static void numSep(int num)
        {
            if(num < 10)
            {
                Console.WriteLine(num);
                return;
            }
            numSep(num / 10);
            Console.WriteLine(num % 10);
        }
    }
}
