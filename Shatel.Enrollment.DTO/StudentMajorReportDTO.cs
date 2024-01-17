using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shatel.Enrollment.DTO
{
    public class StudentMajorReportDTO
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int StudentNumber { get; set; }
        public MajorDTO? MajorDTO { get; set; }
    }
}
