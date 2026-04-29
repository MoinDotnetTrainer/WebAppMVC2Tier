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
        Task AddUsers(UsersModel data);   
    }
}
