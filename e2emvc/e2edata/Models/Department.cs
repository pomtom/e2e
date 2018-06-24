using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace e2edata.Models
{
    public class Department
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public IEnumerable<Employees> Employees { get; set; }
    }
}