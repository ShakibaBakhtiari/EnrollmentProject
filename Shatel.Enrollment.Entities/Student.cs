using Shatel.Enrollment.Entities.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shatel.Enrollment.Entities
{
    [Table("Student")]
    public class Student : Person
    {

        [Required(AllowEmptyStrings = false), MaxLength(8, ErrorMessage = "StudentNumber should have 8 digits."), IsUnique]
        public string? StudentNumber { get; set; }

        [ForeignKey("Majorid")]
        public Major? Major { get; set; }

        public int Age { get; set; }
    }
}
