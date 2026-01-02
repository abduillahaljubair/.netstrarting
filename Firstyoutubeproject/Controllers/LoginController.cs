using Microsoft.AspNetCore.Mvc;
using Firstyoutubeproject.Models;
namespace Firstyoutubeproject.Controllers
{
    public class LoginController : Controller
    {
        //strongly helper class for login
        public IActionResult Index()
        {
            Login l=new Login();
            l.username = "admin";
            l.password = "123@admin";
            return View(l);
        }
        public string LoginShow(Login G)
        {
            return G.username + G.password +"you are logging in the page ";
        }
    }
}
