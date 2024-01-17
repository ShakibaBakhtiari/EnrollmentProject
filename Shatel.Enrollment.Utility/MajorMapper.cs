using Shatel.Enrollment.DTO;
using Shatel.Enrollment.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shatel.Enrollment.Utility
{
    public class MajorMapper
    {
        public Major MapDTOToModel(MajorDTO majorDTO)
        {
            return new Major()
            {
                Name = majorDTO.Name,
                Id = majorDTO.Id,
            };
        }
        public MajorDTO MapModeltoDTO(Major major)
        {
            return new MajorDTO()
            {
                Name = major.Name,
                Id = major.Id,
            };
        }
    }
}
