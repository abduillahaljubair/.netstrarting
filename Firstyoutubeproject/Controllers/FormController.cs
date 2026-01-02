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
        /*  13      creating form controller object or to receive data from model student.cs
        */
        [HttpPost]

        /* binding er khetre ba object er khetre obostai input er nam same thakte hobe  */
        public IActionResult Showform(student data)
        {
            ViewBag.Name = data.Name;
            ViewBag.Age = data.Age;
            ViewBag.Grade = data.Grade;
            ViewBag.Balance = data.Balance;
           
            return View();
        }
    }
}
