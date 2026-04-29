using DAlayer.IRepos;
using DAlayer.Models;
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

        public async Task AddUsers(UsersModel data) {
            //await keyword
            await _db.Users.AddAsync(data);
            await _db.SaveChangesAsync();
            //1.model -- fetched the data
            //2 connection 
            //3 map data 
            //4.insert
                //save
        }
    }
}
