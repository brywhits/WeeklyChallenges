﻿using System;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet01
    {
        public bool AreTwoNumbersTheSame(int num1, int num2)
        {
            if(num1 == num2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double Subtract(double minuend, double subtrahend)
        {
            var sum = minuend - subtrahend;
            return sum;
        }

        public int Add(int number1, int number2)
        {
            var sum = number1 + number2;
            return sum;
        }

        public int GetSmallestNumber(int number1, int number2)
        {
            var sum = number1 < number2 ? number1 : number2;
            return sum;
        }

        public long Multiply(long factor1, long factor2)
        {
            var sum = factor1 * factor2;
            return sum;
        }

        public string GetGreeting(string nameOfPerson)
        {
            return string.IsNullOrEmpty(nameOfPerson) ? "Hello!" : $"Hello, {nameOfPerson}!";
        }

        public string GetHey()
        {
            return "HEY!";
        }
    }
}
