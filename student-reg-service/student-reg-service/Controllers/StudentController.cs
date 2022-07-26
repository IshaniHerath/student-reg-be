using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace student_reg_service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        public readonly StudentService _student;

        public StudentController(StudentService student)
        {
            _student = student;
        }   

        public async Task<ActionResult<Student>> GetStudentData()
        {
            return await _student.getData();
        }
    }
}
