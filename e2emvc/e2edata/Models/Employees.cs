using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace e2edata.Models
{
    public class Employees
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public DateTime Date { get; set; }

        public byte[] Photo { get; set; }

        public virtual Department Department { get; set; }

    }
}