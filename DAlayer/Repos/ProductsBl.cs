using DAlayer.IRepos;
using DAlayer.Models;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAlayer.Repos
{
    public class ProductsBl : IProducts
    {
        public readonly AppDb _db;
        public ProductsBl(AppDb db)
        {
            _db = db;
        }
        public async Task<bool> Addproducts(Products data)
        {
            await _db.Products.AddAsync(data);
            int res = await _db.SaveChangesAsync();
            if (res>0)
            {
                return true;
            }
            return false;
        }

    }
}
