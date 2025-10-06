namespace BlazorÖvningar.Services;
using BlazorÖvningar.Models;

public interface IStudentService
{
    List<Student> GetStudents();
    void AddStudent(Student student);
    void DeleteStudent(Guid id);
}