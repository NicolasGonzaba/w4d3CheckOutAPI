using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using w4d3CheckOutAPI.Models;
using w4d3CheckOutAPI.Services;

namespace w4d3CheckOutAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class StudentController : ControllerBase
{
    private readonly IStudentService aStudentService;
    public StudentController(IStudentService StudentService)
    {
        aStudentService = StudentService;
    }

    [HttpGet("GetStudentList")]
    public List<Student> GetStudents()
    {
        return aStudentService.GetStudents();
    }
    [HttpGet("GetStudentList/{id}")]
    public Student? GetStudents(int id)
    {
        return aStudentService.GetStudentById(id);
    }
    [HttpPost("AddStudent/{id}")]
    public Student AddStudent(Student student)
    {
        return aStudentService.AddStudent(student);
    }
    [HttpPut("updateStudent/{id}")]
    public Student? UpdateStudent(int id,Student student)
    {
        return aStudentService.UpdateStudent(id,student);
    }
    [HttpDelete("removeStudent/{id}")]
    public bool DeleteDevice(int id)
    {
        return aStudentService.DeleteStudent(id);
    }

}
