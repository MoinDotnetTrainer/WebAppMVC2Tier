using DAlayer.IRepos;
using DAlayer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Operations;

namespace WebAppMVC2Tier.Controllers
{
    public class BooksOpsController : Controller
    {
        public readonly Ibooks _ibooks;
        public BooksOpsController(Ibooks ibooks)
        {
            _ibooks = ibooks;
        }

        [HttpGet]
        public IActionResult AddBooks()
        {
            return View();
        }

        [HttpPost]

        public async Task<IActionResult> AddBooks(Books data)
        {
            var res = await _ibooks.AddBooks(data);
            if (res)
            {
                return RedirectToAction("GetBooks");
            }
            return View();
        }
    }
}
