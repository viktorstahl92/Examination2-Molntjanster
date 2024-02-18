namespace Molntjanster.UseCases.ManageStudents.Models
{
    public record StudentModel
    {
        public string? StudentName { get; init; }
        public string? Email { get; init; }
        public string? Examination { get; } = "Examination 2";
    }
}
