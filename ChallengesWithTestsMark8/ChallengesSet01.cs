﻿using System;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet01
    {
        public bool AreTwoNumbersTheSame(int num1, int num2)
        {
            // Inline If
            return (num1 == num2) ? true : false;
            // If else statement
            //if(num1 == num2)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
        }

        public double Subtract(double minuend, double subtrahend)
        {
            return minuend - subtrahend;
        }

        public int Add(int number1, int number2)
        {
            return number1 + number2;
        }

        public int GetSmallestNumber(int number1, int number2)
        {
            // Inline if
            return (number1 < number2) ? number1 : number2;

            // If else statement
            //if (number1 < number2)
            //{
            //    return number1;
            //}
            //else
            //{
            //    return number2;
            //}
        }

        public long Multiply(long factor1, long factor2)
        {
            return factor1 * factor2;
        }

        public string GetGreeting(string nameOfPerson)
        {
            if (nameOfPerson == "")
            {
                return "Hello!";
            }
            else
            {
                return $"Hello, {nameOfPerson}!";
            }
        }

        public string GetHey()
        {
            return "HEY!";
        }
    }
}
