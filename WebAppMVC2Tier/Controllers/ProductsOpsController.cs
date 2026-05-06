using DAlayer.IRepos;
using DAlayer.Models;
using Microsoft.AspNetCore.Mvc;

namespace WebAppMVC2Tier.Controllers
{
    public class ProductsOpsController : Controller
    {
        public readonly IProducts _iproducts;
        public ProductsOpsController(IProducts iproducts)
        {
            _iproducts = iproducts;
        }

        [HttpGet]
        public IActionResult Addproducts()
        {
            return View();
        }

        [HttpPost]

        public async Task< IActionResult> Addproducts(Products data)
        {
          var res =  await _iproducts.Addproducts(data);
            if (res)
            {
                return RedirectToAction("GetProducts");
            }
            return View();
        }
    }
}
