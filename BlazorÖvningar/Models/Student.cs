namespace BlazorÖvningar.Models;

public class Student
{
    // Unik identifierare för borttagning/redigering
    public Guid Id { get; set; } = Guid.NewGuid();

    // Namnet på studenten (Krav: sortera efter namn)
    public string Name { get; set; } = string.Empty;

    // Betyget (Krav: sortera efter betyg)
    public int Grade { get; set; } = 0;
}