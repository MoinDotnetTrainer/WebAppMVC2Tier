using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAlayer.Models
{
    public class Books
    {
        [Key] public int BookId { get; set; }
        public string BookName { get; set; }
        public string Author { get; set; }
    }
}
