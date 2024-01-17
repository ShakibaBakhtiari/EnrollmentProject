using Shatel.Enrollment.DTO;
using Shatel.Enrollment.Entities;

namespace Shatel.Enrollment.Utility
{
    public class StudentMapper
    {
        public Student MapDTOToModel(StudentDTO studentDTO)
        {
            return new Student()
            {
                FirstName = studentDTO.FirstName,
                LastName = studentDTO.LastName,
                Id = studentDTO.Id,
                Age = studentDTO.Age,
                NationalId = studentDTO.NationalId,
                PhoneNumber = studentDTO.PhoneNumber,
                StudentNumber = studentDTO.StudentNumber,
                Address = studentDTO.Address,
                Major = new Entities.Major
                {
                    Id = studentDTO.Major.Id,
                    Name = studentDTO.Major.Name,
                },
            };
        }
        public StudentDTO MapModeltoDTO(Student student)
        {
            return new StudentDTO()
            {
                FirstName = student.FirstName,
                LastName = student.LastName,
                Address = student.Address,
                NationalId = student.NationalId,
                StudentNumber = student.StudentNumber,
                PhoneNumber = student.PhoneNumber,
                Id = student.Id,
                Age = student.Age,
                Major = new DTO.MajorDTO {
                    Id = student.Major.Id,
                    Name = student.Major.Name,
                },
            };
        }
    }
}