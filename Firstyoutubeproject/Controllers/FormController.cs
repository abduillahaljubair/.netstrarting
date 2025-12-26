using Microsoft.AspNetCore.Mvc;
using Firstyoutubeproject.Models;

namespace Firstyoutubeproject.Controllers
{
    public class FormController : Controller
    {
        public IActionResult FormShow()
        {
            return View();
        }
/*        creating form controller object to receive data from model student.cs
*/        public IActionResult Showform(student data)
        {
            ViewBag.Name = data.Name;
            ViewBag.Age = data.Age;
            ViewBag.Balance = data.Balance;
            ViewBag.Grade = data.Grade;
            return View();
        }
    }
}
