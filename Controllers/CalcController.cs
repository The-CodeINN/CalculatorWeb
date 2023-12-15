using CalculatorWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace CalculatorWeb.Controllers
{
    public class CalcController : Controller
    {
        public IActionResult Index()
        {
            return View(new Calc());
        }

        [HttpPost]
        public IActionResult Index(Calc c, string calculate)
        {
            if (calculate == "add")
            {
                c.total = c.num1 + c.num2;
            } else if (calculate == "sub")
            {
                c.total = c.num1 - c.num2;
            } else if(calculate == "multiply")
            {
                c.total += c.num1 * c.num2;
            } else
            {
                c.total = c.num1 / c.num2;
            }

            return View(c);
        }
    }
}
