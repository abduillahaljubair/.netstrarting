using Firstyoutubeproject.Models;//importing model namespace
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Firstyoutubeproject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
       /* public string AboutUs() //user request pathabe ei action er jonno 
        {
            return "this is about us"; //ar ei action ee ki pawajabe seita return korbe 
        }*/
       public IActionResult AboutUs()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }
        //View er pasha pashi Shared folder ta automatic search kore dekhbe je action file ta ase kina 
        public IActionResult ContactUS()
        {
            return View();
        }
        //default namer action korlam but view ke bole dilam Index namer file ta khulo
       public IActionResult Default()
        {
            return View("Index");
        }
       /* public IActionResult studentinfo()
        {
            student s1= new student("rahim",21,"A+",5000);
            *//*student s1 = new student()
            { 
                Name = "rahim",
                Age = 21,
                Grade = "A+",
                Balance = 5000
            };*//*

            return View(s1);
        }*/
        public IActionResult studentinfo()
        {
            List<student> s1 = new List<student>();
            s1.Add(new student("jubair", 12, "A+", 500));
            s1.Add(new student("jub", 19, "A-", 6500));
            s1.Add(new student("jamal", 18, "B-", 62500));

            /*List<student> s1 = new List<student>()
            {
                new student(){Name="Rahim",Age=12,Balance=20300,Grade="A+"},
                  new student(){Name="Karim",Age=13,Balance=21000,Grade="B+"},
                    new student(){Name="jabbar",Age=19,Balance=12000,Grade="A-"},
                      new student(){Name="mahmud",Age=19,Balance=23000,Grade="A"}
            };*/

            return View(s1);
        }
         /*7 view data function  */
        public IActionResult viewdatadescription()
        {
            ViewData["prodid"] = 1;
            ViewData["prodname"] = "laptop";
            ViewData["prodprice"] = 45000;
            ViewData["proqyantity"]= 5;
            return View();
        }

        /*8 view Bag function  */
        /*properties hisabe use kore 
            .diye access kora jay*/
        public IActionResult viewbagdescription()
        {
           ViewBag.prodid = 2;
              ViewBag.prodname = "mobile";
                ViewBag.prodprice = 25000;
         

            return View();
        }

/*    9    using RedirectToActionResult jekhane ekta page call dewar age arekta page e call dewa  */


        public IActionResult redirectaction()
        {
            TempData["message"] = "you are being redirected to about us page";
            return RedirectToAction("AboutUs");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
