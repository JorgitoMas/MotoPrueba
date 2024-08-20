using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moto.Domain.Models
{
    public class User : BaseModel
    {
        [Required]
        [MaxLength(100)]
        [Column("Name")]
        public string Name { get; set; }
        [Required]
        [MaxLength(100)]
        [Column("UserName")]
        public string UserName { get; set; }
        [Required]
        [MaxLength(100)]
        [Column("Email")]
        public string Email { get; set; }
        [Required]
        [MaxLength(100)]
        [Column("Password")]
        public string Password { get; set; }

    }
}
