using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using w4d3CheckOutAPI.Models;

namespace w4d3CheckOutAPI.Services;

public class StudentService : IStudentService
{
    List<Student> _studentList = new();

    public StudentService()
    {
        _studentList.Add(new Student
        {
            Id = 1,
            FullName = "Ken Martinez",
            Email = "KMartinez@gmail.com",
            DeviceCheckedOutId = 1
        });
        _studentList.Add(new Student
        {
            Id = 2,
            FullName = "Nicolas Gonzaba",
            Email = "NGonzaba@gmail.com",
            DeviceCheckedOutId = 3
        });
    }

    public Student AddStudent(Student newStudent)
    {
        int newID = _studentList.Count == 0 ? 1 : _studentList.Max(s => s.Id) + 1;
        newStudent.Id=newID;
        _studentList.Add(newStudent);
        return newStudent;
    }

    public bool DeleteStudent(int id)
    {
        Student? student=_studentList.FirstOrDefault(s=>s.Id==id);
        if (student == null)
        {
            return false;
        }
        _studentList.Remove(student);
        return true;
    }

    public Student? GetStudentById(int id)
    {
        return _studentList.FirstOrDefault(s=>s.Id==id);
    }

    public List<Student> GetStudents()
    {
        return _studentList;
    }

    public Student? UpdateStudent(int id, Student updatedStudent)
    {
        Student? existingStudent=_studentList.FirstOrDefault(s=>s.Id==id);
        if (existingStudent == null)
        {
            return null;
        }
        existingStudent.FullName=updatedStudent.FullName;
        existingStudent.Email=updatedStudent.Email;
        existingStudent.DeviceCheckedOutId=updatedStudent.DeviceCheckedOutId;

        return existingStudent;
    }
}
