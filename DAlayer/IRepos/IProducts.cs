using DAlayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAlayer.IRepos
{
    public interface IProducts
    {
        Task<bool> Addproducts(Products data);
    }
}
