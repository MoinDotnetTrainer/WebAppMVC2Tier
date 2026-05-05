using DAlayer.IRepos;
using DAlayer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAlayer.Repos
{
    public class UsersBl : IUsers
    {
        // implemnt lof=gic for insert
        // dbcontexctr ,db set

        public readonly AppDb _db;
        public UsersBl(AppDb db)
        {
            _db = db;
        }

        public async Task<bool> AddUsers(UsersModel data)
        {
            //await keyword
            await _db.Users.AddAsync(data);
            int no = await _db.SaveChangesAsync();
            if (no > 0)
            {
                return true;
            }
            return false;
            //1.model -- fetched the data
            //2 connection 
            //3 map data 
            //4.insert
            //save
        }

        public async Task<List<UsersModel>> GetUsers()
        {
            var res = await (from s in _db.Users select s).ToListAsync();
            return res;
        }

        public async Task<UsersModel> GetUserByID(int ID)
        {
            var res = await _db.Users
                      .Where(s => s.ID == ID)
                      .FirstOrDefaultAsync();
            return res;
        }

        public async Task<bool> UpdateUsers(UsersModel data)
        {
            //await keyword
            _db.Users.Update(data);
            int no = await _db.SaveChangesAsync();
            if (no > 0)
            {
                return true;
            }
            return false;
            //1.model -- fetched the data
            //2 connection 
            //3 map data 
            //4.insert
            //save
        }

    }
}
