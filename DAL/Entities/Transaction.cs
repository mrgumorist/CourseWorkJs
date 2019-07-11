using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Transaction
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string FromName { get; set; }
        [Required]
        public string ToName { get; set; }
        [Required]
        public string CountFrom { get; set; }
        [Required]
        public string CountTo { get; set; }

    }
}
