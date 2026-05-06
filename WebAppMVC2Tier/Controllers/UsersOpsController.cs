using DAlayer.IRepos;
using DAlayer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.Blazor;
using System.Threading.Tasks;

namespace WebAppMVC2Tier.Controllers
{
    public class UsersOpsController : Controller
    {

        public readonly IUsers _Iuser;
        public UsersOpsController(IUsers iuser)
        {
            _Iuser = iuser;
        }
        [HttpGet]
        public IActionResult InsertUsers()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> InsertUsers(UsersModel data)
        {
            var result = await _Iuser.AddUsers(data);
            if (result)
            {
                return RedirectToAction("DisplayUsers");
            }
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> DisplayUsers()
        {
            var res = await _Iuser.GetUsers();
            return View(res);
        }


        [HttpGet]
        public async Task<IActionResult> Edit(int ID) {
            var res = await _Iuser.GetUserByID(ID);
            return View(res);
        }


        [HttpPost]
        public async Task<IActionResult> Edit(UsersModel data)
        {
            var result = await _Iuser.UpdateUsers(data);
            if (result)
            {
                return RedirectToAction("DisplayUsers");
            }
            return View();
        }


        [HttpGet]
        public async Task<IActionResult> Delete(int ID)
        {
            var res = await _Iuser.GetUserByID(ID);
            return View(res);
        }


        [HttpPost,ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirm(int ID)
        {
            var result = await _Iuser.DeleteUsers(ID);
            if (result)
            {
                return RedirectToAction("DisplayUsers");
            }
            return View();
        }
    }
} 
