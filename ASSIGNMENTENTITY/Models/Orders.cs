using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ASSIGNMENTENTITY.Models
{
    [Table("order")]
    public class Orders
    {
        [Key]
        public string Ordersid { get; set; }
        [Required]
        [StringLength(30)]
        [Column(TypeName = "Date")]
        public DateTime? Ordersdate { get; set; }
       public DateTime? deliverydate { get; set; }
        public int ItemID { get; set; }
        [ForeignKey("ItemID")]
        public Item Item { get; set; }
    }
}
