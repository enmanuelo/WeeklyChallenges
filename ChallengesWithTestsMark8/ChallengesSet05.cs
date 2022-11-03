using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            int num = startNumber + 1;
            while (true)
            {
                if (num % n == 0)
                {
                    return num;
                }
                num++;
            }
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            businesses.Where(x => x.TotalRevenue == 0).ToList().ForEach(x => x.Name = "CLOSED");            
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return false;
            }
            var ascenNums = numbers.OrderBy(x => x);
            return Enumerable.SequenceEqual(numbers, ascenNums);
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {            
            int sum = 0;
            if (numbers == null)
            {
                return 0;
            }
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i - 1] % 2 == 0)
                {
                    sum += numbers[i];
                }
            }
            return sum;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            //Incomplete
            if (words == null || words.Length == 0)
            {
                return "";
            }
            return string.Join(" ", words) + ".";
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            if (elements == null)
            {
                return new double[0];
            }
            var elms = new List<double>();
            for (int i = 0; i < elements.Count; i++)
            {
                if ((i+1) % 4 == 0)
                {
                    elms.Add(elements[i]);
                }
            }
            return elms.ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            throw new NotImplementedException();
        }
    }
}
