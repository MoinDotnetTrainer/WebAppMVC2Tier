using DAlayer.IRepos;
using DAlayer.Models;
using Microsoft.AspNetCore.Mvc;
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
            await _Iuser.AddUsers(data);
            return View();
        }
    }
}
