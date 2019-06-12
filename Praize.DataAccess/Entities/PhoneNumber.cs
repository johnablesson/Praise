using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Praize.DataAccess.Entities
{
    public class PhoneNumber
    {
        [Key]
        public Guid Id { get; set; }

        public Guid UserId { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }

        [StringLength(20)]
        [Required]
        public string Number { get; set; }

        [StringLength(10)]
        public string Extension { get; set; }

        public DateTimeOffset? CreatedDate { get; set; }

    }
}
