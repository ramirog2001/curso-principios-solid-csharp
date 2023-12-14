using Microsoft.AspNetCore.Mvc;

namespace DependencyInversion.Controllers;

[ApiController, Route("student")]
public class StudentController : ControllerBase
{
    IStudentRepository studentRepository;
    ILogbook logbook;

    public StudentController(IStudentRepository studentRepository, ILogbook logbook)
    {
        this.studentRepository = studentRepository;
        this.logbook = logbook;
    }

    [HttpGet]
    public IEnumerable<Student> Get()
    {
        logbook.Add($"returning student's list");
        return studentRepository.GetAll();
    }

    [HttpPost]
    public Student Add([FromBody]Student student)
    {
        var result = studentRepository.Add(student);
        logbook.Add($"The Student {student.Fullname} have been added");

        return result;
    }
}
