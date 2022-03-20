using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebLab2._1.Models;
using WebLab2._1.Services;

namespace WebLab2._1.Controllers
{
    [Route("CalcService")]
    public class CalcServiceController : Controller
    {
        [Route("PassUsingModel")]
        public IActionResult PassUsingModel()
        {
            return View(CalcService.GetCalcValues());
        }

        [Route("PassUsingViewBag")]
        public IActionResult PassUsingViewBag(CalcValues calcValues)
        {
            var values = CalcService.GetCalcValues();
            ViewBag.CalcValues = new CalcValues()
            {
                FirstRandValue = values.FirstRandValue,
                SecondRandValue = values.SecondRandValue,
                Sum = values.Sum,
                Difference = values.Difference,
                Multiplication = values.Multiplication,
                Division = values.Division
            };
            return View();
        }

        [Route("PassUsingViewData")]
        public IActionResult PassUsingViewData()
        {
            var values = CalcService.GetCalcValues();
            ViewData["CalcValues"] = new CalcValues()
            {
                FirstRandValue = values.FirstRandValue,
                SecondRandValue = values.SecondRandValue,
                Sum = values.Sum,
                Difference = values.Difference,
                Multiplication = values.Multiplication,
                Division = values.Division
            };
            return View();
        }

        [Route("AccessServiceDirectly")]
        public IActionResult AccessServiceDirectly()
        {
            return View();
        }
    }
}