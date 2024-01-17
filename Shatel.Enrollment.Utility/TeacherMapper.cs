using Shatel.Enrollment.DTO;
using Shatel.Enrollment.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shatel.Enrollment.Utility
{
    public class TeacherMapper
    {
        public Teacher MapDTOToModel(TeacherDTO teacherDTO)
        {
            return new Teacher()
            {
                FirstName = teacherDTO.FirstName,
                LastName = teacherDTO.LastName,
                Id = teacherDTO.Id,
                NationalId = teacherDTO.NationalId,
                PhoneNumber = teacherDTO.PhoneNumber,
                Address = teacherDTO.Address,
                PersonalityId = teacherDTO.PersonalityId,
            };
        }
        public TeacherDTO MapModeltoDTO(Teacher teacher)
        {
            return new TeacherDTO()
            {
                FirstName = teacher.FirstName,
                LastName = teacher.LastName,
                Address = teacher.Address,
                NationalId = teacher.NationalId,
                PhoneNumber = teacher.PhoneNumber,
                Id = teacher.Id,
                PersonalityId = teacher.PersonalityId,
            };
        }
    }
}
