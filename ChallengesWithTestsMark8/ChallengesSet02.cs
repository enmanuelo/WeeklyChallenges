using System;
using System.Linq;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            int sum = 0;
            foreach (var val in vals)
            {
                sum++;
            }

            return sum % 2 == 0;
        }

        public bool IsNumberEven(int number)
        {
            return number % 2 == 0;
        }

        public bool IsNumberOdd(int num)
        {
            return num % 2 != 0;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {

            return numbers == null || numbers.Count() == 0? 0 : numbers.Min() + numbers.Max();
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if (str1.Length < str2.Length)
            {
                return str1.Length;
            }
            else
            {
                return str2.Length;
            }
        }

        public int Sum(int[] numbers)
        {
            return numbers == null || numbers.Count() == 0 ? 0 : numbers.Sum();
        }

        public int SumEvens(int[] numbers)
        {
            return numbers == null || numbers.Count() == 0 ? 0 : numbers.Where(x => x % 2 == 0).Sum();
            //int sum = 0;
            //foreach (var num in numbers)
            //{
            //    if (num % 2 == 0)
            //    {
            //        sum += num;
            //    }
            //}
            //return sum;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            int sum = 0;
            foreach (var num in numbers)
            {
                sum += num;
            }
            return sum % 2 != 0;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            int sum = 0;
            for (int i = 0; i < number; i++)
            {
                if (i % 2 != 0)
                { 
                    sum += i;
                }
            }
            return sum;
        }
    }
}
