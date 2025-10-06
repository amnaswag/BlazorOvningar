namespace BlazorÖvningar.Models;

using System;

public class Student
{
    public Guid Id { get; set; } = Guid.NewGuid();

    public string Name { get; set; } = string.Empty;

    public int Grade { get; set; } = 0;
}