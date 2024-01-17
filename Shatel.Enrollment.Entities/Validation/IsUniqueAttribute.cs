using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shatel.Enrollment.Entities.Validation
{
    public class IsUniqueAttribute : Attribute
    {
        public virtual bool unique { get; set; }
    }
}
