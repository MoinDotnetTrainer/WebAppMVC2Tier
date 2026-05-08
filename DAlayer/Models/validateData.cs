using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAlayer.Models
{
    public class validateData
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage ="Name Required")]  // validating our null data
        public string Name { get; set; }

        [Required(ErrorMessage ="Email Required")]
        public string Email { get; set; }

        [Required(ErrorMessage ="password Required")]
        public string Password { get; set; }
    }
}
