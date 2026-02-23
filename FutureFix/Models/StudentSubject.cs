namespace FutureFix.Models;

public class StudentSubject
{
    public int Id { get; set; }

    public int StudentProfileId { get; set; }
    public StudentProfile? StudentProfile { get; set; }

    public int SubjectId { get; set; }
    public Subject? Subject { get; set; }
}
