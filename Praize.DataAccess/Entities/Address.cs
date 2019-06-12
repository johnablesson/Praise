using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Praize.DataAccess.Entities
{
    public class Address
    {
        [Key]
        public Guid Id { get; set; }

        public Guid UserId { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }

        [ForeignKey("AddressTypeId")]
        public AddressType AddressType { get; set; }

        public int AddressTypeId { get; set; }

        [StringLength(100)]
        public string HouseNo { get; set; }

        [StringLength(100)]
        public string Street { get; set; }

        [StringLength(100)]
        [Required]
        public string City { get; set; }

        [StringLength(100)]
        [Required]
        public string State { get; set; }

        [StringLength(100)]
        [Required]
        public string Country { get; set; }

        [StringLength(10)]
        public string Zip { get; set; }

        public DateTimeOffset? CreatedDate { get; set; }
    }
}
