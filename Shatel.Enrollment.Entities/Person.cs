using Shatel.Enrollment.Entities.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shatel.Enrollment.Entities
{
    [Table("Person")]
    public class Person : BaseEntity
    {
        [Required(AllowEmptyStrings = false)]
        public string FirstName { get; set; }
        
        [Required(AllowEmptyStrings = false)]
        public string LastName { get; set; }
        
        [MaxLength(11, ErrorMessage = "PhoneNumber should be 11 digits"), MinLength(11, ErrorMessage = "PhoneNumber should be 11 digits")]
        public string? PhoneNumber { get; set; }
        
        public string Address { get; set; }
        
        [Required(AllowEmptyStrings = false)]
        [IsUnique]
        public string? NationalId { get; set; }
    }
}