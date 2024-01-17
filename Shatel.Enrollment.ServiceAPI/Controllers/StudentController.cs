using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shatel.Enrollment.Businesslayer;
using Shatel.Enrollment.DTO;
using Shatel.Enrollment.Entities;

namespace Shatel.Enrollment.ServiceAPI.Controllers
{
    [ApiController]
    [Route("api")]
    public class StudentController : ControllerBase
    {
        StudentBusiness studentBusiness = new StudentBusiness();

        [HttpGet]
        [Route("student/GetAll")]
        public List<Student> GetAll()
        {
            return studentBusiness.GetAllStudents();
        }
        [HttpPost]
        [Route("student/Enroll")]
        public void Enrollment(StudentDTO studentDTO)
        {
            studentBusiness.EnrollStudent(studentDTO);
        }
        [HttpPut]
        [Route("student/Update")]
        public bool ChangeInfoStudent(StudentDTO studentDTO)
        {
            studentBusiness.ChangeInfoStudent(studentDTO);
            return true;
        }
        [HttpDelete]
        [Route("student/delete")]
        public bool DeleteInfoStudent(int id)
        {
            studentBusiness.DeleteInfoStudent(id);
            return true;
        }
    }
}
