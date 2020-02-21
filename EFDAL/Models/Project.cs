using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EFDAL.Models
{
    [Table("Project4")]
  public  class Project4
    {
       [Key]
        public int ProjectID { get; set; }
        [Required]
        [StringLength(30)]
        public string ProjectName { get; set; }
     
     
        public IEnumerable<Employee> Employees { get; set; }
    }
}
