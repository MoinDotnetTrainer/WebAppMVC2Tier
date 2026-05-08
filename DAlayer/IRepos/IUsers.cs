using DAlayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAlayer.IRepos
{
    public interface IUsers
    {
        // Abstract methods for Curd opes for users
        // async & await --> asynchrous
        Task<bool> AddUsers(UsersModel data);
        // display users
        Task<List<UsersModel>> GetUsers();
        // get user by id
        Task<UsersModel> GetUserByID(int ID);
        Task<bool> UpdateUsers(UsersModel data);
        Task<bool> DeleteUsers(int ID);

        Task<bool> Login(LoginModel data);

    }
}
