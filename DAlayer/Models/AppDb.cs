using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAlayer.Models
{
    public class AppDb : DbContext
    {
        //static
        public AppDb(DbContextOptions options):base(options) { }

        //connection string

        public DbSet<UsersModel> Users { get; set; }
    }
}
