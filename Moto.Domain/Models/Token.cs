using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moto.Domain.Models
{
    public class Token : BaseModel
    {
        [Required]
        [Column("TokenValue")]
        public string TokenValue { get; set; }
        [Required]
        [Column("StartDate")]
        public DateTime StartDate { get; set; }
        [Required]
        [Column("EndDate")]
        public DateTime EndDate { get; set; }
        [Required]
        [Column("IsValid")]
        public bool IsValid { get; set; }
        [Required]
        [Column("UserId")]
        public long UserId { get; set; }
        [ForeignKey(nameof(UserId))]
        public User User { get; set; }
    }
}
