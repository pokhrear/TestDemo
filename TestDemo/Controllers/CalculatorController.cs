using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TestDemo.Models;

namespace TestDemo.Controllers
{
    public class CalculatorController : Controller
    {
        private readonly ILogger<CalculatorController> _logger;

        public CalculatorController(ILogger<CalculatorController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        public IActionResult Mortgage()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Mortgage(Operation model)
        {
            var actualLoan = model.Number1 - model.Number2;
            var actualRate = model.Number3 / 12;
            var FinalmonthlyPayment = actualLoan * (actualRate *( Math.Pow(1 + actualRate, model.Number4))) /(Math.Pow(1 + actualRate, model.Number4) - 1);
            model.Result =  Math.Round(FinalmonthlyPayment, 2);

           

          
            return View(model);
        }
    }
}