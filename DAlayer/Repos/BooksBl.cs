using DAlayer.IRepos;
using DAlayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAlayer.Repos
{
    public class BooksBl : Ibooks
    {
        public readonly AppDb _db;
        public BooksBl(AppDb db) {
            _db = db;
        }

        public async Task<bool> AddBooks(Books data)
        {
            await _db.Books.AddAsync(data);
            int res = await _db.SaveChangesAsync();
            if (res > 0)
            {
                return true;
            }
            return false;
        }
    }
}
