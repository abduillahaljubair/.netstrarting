using Microsoft.AspNetCore.Mvc;
using Firstyoutubeproject.Models;
namespace Firstyoutubeproject.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            Login l=new Login("admin","1234");
            return View(l);
        }
    }
}
