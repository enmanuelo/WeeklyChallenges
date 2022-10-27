using System;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            var sum = 0;
            foreach (var num in numbers)
            {
                sum = (num % 2 == 0) ? (sum + num) : (sum - num);
            }
            return sum;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            var shortString = str1;
            if (str2.Length < shortString.Length)
            {
                shortString = str2;
            }
            if (str3.Length < shortString.Length)
            {
                shortString = str3;
            }
            if (str4.Length < shortString.Length)
            {
                shortString = str4;
            }
            return shortString.Length;
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            var smallNum = number1;
            if (number2 < smallNum)
            {
                smallNum = number2;
            }
            if (number3 < smallNum)
            {
                smallNum = number3;
            }
            if (number4 < smallNum)
            {
                smallNum = number4;
            }
            return smallNum;
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            var criteriaOne = sideLength1 + sideLength2 > sideLength3;
            var criteriaTwo = sideLength1 + sideLength3 > sideLength2;
            var criteriaThree = sideLength2 + sideLength3 > sideLength1;
            return (criteriaOne && criteriaTwo && criteriaThree);
        }

        public bool IsStringANumber(string input)
        {
            return int.TryParse(input, out int i) || double.TryParse(input, out double d);
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            throw new NotImplementedException();
        }

        public double AverageEvens(int[] numbers)
        {
            throw new NotImplementedException();
        }

        public int Factorial(int number)
        {
            throw new NotImplementedException();
        }
    }
}
