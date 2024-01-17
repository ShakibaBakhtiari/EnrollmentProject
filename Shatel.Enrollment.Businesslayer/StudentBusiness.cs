using Shatel.Enrollment.DataAccess;
using Shatel.Enrollment.DTO;
using Shatel.Enrollment.Entities;
using Shatel.Enrollment.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shatel.Enrollment.Businesslayer
{
    public class StudentBusiness
    {
        StudentRepository studentRepository = new StudentRepository();
        public void EnrollStudent(StudentDTO studentDTO)
        {
            studentRepository.Create(new StudentMapper().MapDTOToModel(studentDTO));
        }
        public List<Student> GetAllStudents()
        {
            return studentRepository.ReadAll();
        }
        public Student GetSpecificStudent(int id)
        {
            return studentRepository.ReadById(id);
        }
        public bool ChangeInfoStudent(StudentDTO studentDTO)
        {
            var student = studentRepository.ReadById(studentDTO.Id);
            student.FirstName = studentDTO.FirstName;
            student.LastName = studentDTO.LastName;
            student.NationalId = studentDTO.NationalId;
            student.Age = studentDTO.Age;
            student.PhoneNumber = studentDTO.PhoneNumber;
            student.StudentNumber = studentDTO.StudentNumber;
            student.Address = studentDTO.Address;
            student.Major = new Entities.Major
            {
                Id = studentDTO.Major.Id,
                Name = studentDTO.Major.Name,
            };

            return studentRepository.Update(student);
        }
        public bool DeleteInfoStudent(int Id)
        {
            return studentRepository.DeleteById(Id);
        }
        public StudentDTO GetSpecificStudentBySTN(string stn)
        {
            return studentRepository.GetStudentByStudentNumber(stn);
        }
    }
}
