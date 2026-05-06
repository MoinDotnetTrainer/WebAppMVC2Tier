using DAlayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAlayer.IRepos
{
    public interface Ibooks
    {
        Task<bool> AddBooks(Books data);
    }
}
