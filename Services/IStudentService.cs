using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using w4d3CheckOutAPI.Models;

namespace w4d3CheckOutAPI.Services;

    public interface IStudentService
    {
       Student AddStudent(Student newStudent);
       List<Student> GetStudents();
       Student? GetStudentById(int id);
       Student? UpdateStudent(int id, Student updatedStudent);
       bool DeleteStudent(int id);
    }
