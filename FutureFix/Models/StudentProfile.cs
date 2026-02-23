using System.ComponentModel.DataAnnotations;

namespace FutureFix.Models;

public class StudentProfile
{
    public int Id { get; set; }

    public string UserId { get; set; } = string.Empty;


    [Required]
    public string FullName { get; set; } = string.Empty;

    [Required]
    public string School { get; set; } = string.Empty;

    [Required]
    public string Stream { get; set; } = string.Empty;

    public List<StudentSubject>? Subjects { get; set; }
}

