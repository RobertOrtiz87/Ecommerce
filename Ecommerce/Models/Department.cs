using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Ecommerce.Models
{
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }

        [Required(ErrorMessage ="The field {0} is requerid")]
        [MaxLength(50, ErrorMessage ="The filed {0} must be maximum {1} characters lenght")]
        [Display(Name = "Department")]
        public string Name { get; set; }

        public virtual ICollection<City> Cities { get; set; }
    }
}