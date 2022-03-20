using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebLab2._1.Models;

namespace WebLab2._1.Services
{
    public class CalcService
    {
        private const int Range = 11;
        public static CalcValues GetCalcValues()
        {
            var rand = new Random();
            var firstValue = rand.Next(Range);
            var secondValue = rand.Next(Range);
            return new CalcValues()
            {
                FirstRandValue = firstValue,
                SecondRandValue = secondValue,
                Sum = firstValue + secondValue,
                Difference = firstValue - secondValue,
                Multiplication = firstValue * secondValue,
                Division = secondValue != 0 ? firstValue / secondValue : null
            };
        }

        public CalcValues GetCalcValues2()
        {
            var rand = new Random();
            var firstValue = rand.Next(Range);
            var secondValue = rand.Next(Range);
            return new CalcValues()
            {
                FirstRandValue = firstValue,
                SecondRandValue = secondValue,
                Sum = firstValue + secondValue,
                Difference = firstValue - secondValue,
                Multiplication = firstValue * secondValue,
                Division = secondValue != 0 ? firstValue / secondValue : null
            };
        }
    }
}
