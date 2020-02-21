using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ASSIGNMENTENTITY.Models
{
    [Table("Item")]
   public class Item
    {

        [Key]
        public int ItemID { get; set; }
        [Required]
        [StringLength(30)]
        public string ItemName { get; set; }
        public int? Itemprice { get; set; }
        public IEnumerable<Orders> Orders { get; set; }
    }
}
