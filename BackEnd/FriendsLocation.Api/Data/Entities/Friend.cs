using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FriendsLocation.Api.Data.Entities
{
    [Table("Friend")]
    public class Friend 
    {
        [Key]
        public int? id { get; set; }

        [Required]
        [MaxLength(100)]
        public string nome { get; set; }

        [Required]
        [MaxLength(1)]
        public string genero { get; set; }

        [Required]
        public double latitude { get; set; }

        [Required]
        public double longitude { get; set; }

        [NotMapped]
        public double distance { get; set; }

    }
}
