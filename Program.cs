using System;

namespace exercise_2
{
    internal class Program
    {
        static int secBiggestno(int[] numbers)
        {
            int[] myNumbers = { 2, 1, 7, 4, 9, 5 };
            int secBiggest = secBiggestno(numbers);
            int lastbiggestNumber = 0;
            Console.WriteLine(secBiggest);
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < lastbiggestNumber )
                {
                    if (numbers[i] > secBiggest)
                    
                        lastbiggestNumber = numbers[i]; 
                }
            }
            return lastbiggestNumber;
        }
        static int biggestnoV2(int[] numbers)
        {
           Array.Sort(numbers);

           return numbers[numbers.Length - 1];
        }
        static int biggestNumber(int[] numbers)
        {
           // Console.WriteLine(numbers[0]);
            int lastbiggestNumber = int.MinValue ;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (lastbiggestNumber < numbers[i])
                {
                    lastbiggestNumber = numbers[i];
                }
            }
            return lastbiggestNumber;
        }
        static void Main(string[] args)
        {
            int[] myNumbers = {2, 1, 7, 4, 9, 5 };
            int biggest = biggestNumber(myNumbers);
            Console.WriteLine(biggest);
        }
    }
}
