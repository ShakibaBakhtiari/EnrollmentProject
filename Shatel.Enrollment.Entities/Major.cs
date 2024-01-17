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
    [Table("Major")]
    public class Major : BaseEntity
    {
        [Required, IsUnique]
        public string? Name { get; set; }
    }
}
