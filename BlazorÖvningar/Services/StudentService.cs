namespace BlazorÖvningar.Services;

using System.Collections.Generic;
using System.Linq;
using BlazorÖvningar.Models;

public class StudentService : IStudentService
{
    // Intern lista som simulerar en databas
    private List<Student> _students = new List<Student>
    {
        // Lägg till några startdata
        new Student { Name = "Amna", Grade = 5 },
        new Student { Name = "Israa", Grade = 3 },
        new Student { Name = "Arber", Grade = 4 }
    };

    public List<Student> GetStudents()
    {
        return _students;
    }

    public void AddStudent(Student student)
    {
        student.Id = System.Guid.NewGuid();
        _students.Add(student);
    }

    public void DeleteStudent(Guid id)
    {
        _students.RemoveAll(s => s.Id == id);
    }
}