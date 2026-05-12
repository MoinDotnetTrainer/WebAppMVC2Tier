using Microsoft.AspNetCore.Mvc;

namespace WebAppMVC2Tier.Controllers
{
    public class Xyz
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
    public class StatetechniqueController : Controller
    {
        public IActionResult Page1()
        {

            ViewBag.vb = "getting data from viewbag " + System.DateTime.Now.ToLongTimeString();
            ViewData["vd"] = "data from viewdata " + System.DateTime.Now.ToLongTimeString();
            TempData["td"] = "data from tempdata " + System.DateTime.Now.ToLongTimeString();
            return RedirectToAction("Page2");
            // return View();
        }
        public IActionResult Page2()
        {


            //  TempData.Peek("td");

            string str = TempData.Peek("td").ToString();

            //  string str = TempData["td"].ToString();
            // keep and peek 
            //     TempData.Keep("td");

            if (str != null)
            {
                ViewBag.res = str;
                return View();

            }
            return View();

        }

        public IActionResult Page3()
        {
            //TempData.Keep("td");
            ViewBag.res = TempData.Peek("td").ToString();
            //  TempData.Keep("td");
            return View();
        }

        public IActionResult Page4()
        {
            List<Xyz> obj = new List<Xyz>() {
            new Xyz { ID=1,Name="kaveri"},
            new Xyz{ ID=2,Name="moin"}
            };
           // ViewBag.res = obj;
               ViewData["res"] = obj;
            return View();
        }


    }
}
