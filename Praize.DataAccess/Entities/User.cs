using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Praize.DataAccess.Entities
{
    public class User
    {
        [Key]
        public Guid Id { get; set; }

        [StringLength(50)]
        [Required]
        public string UserName { get; set; }

        [StringLength(50)]
        [Required]
        public string Password { get; set; }

        [StringLength(50)]
        [Required]
        public string FirstName { get; set; }

        [StringLength(50)]
        public string MiddleName { get; set; }

        [StringLength(50)]
        [Required]
        public string LastName { get; set; }

        [ForeignKey("RoleId")]
        public Role Role { get; set; }

        [Required]
        public int RoleId { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        public ICollection<Address> Addresses { get; set; }

        public ICollection<PhoneNumber> PhoneNumbers { get; set; }

        public DateTimeOffset? CreatedDate { get; set; }
    }
}
