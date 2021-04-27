using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WADWebsite.Models
{
    public class Student
    {
        [Key]
        
        public int ID { get; set; }
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Department")]
        public int DepID { get; set; }

        [Required]
        public string Mobile { get; set; }
        public string Description { get; set; }

        [Required]
        
        
        public DateTime? JoinDate { get; set; }

        [NotMapped]
        public string Department { get; set; }


    }
}
