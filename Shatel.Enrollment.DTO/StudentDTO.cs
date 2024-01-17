namespace Shatel.Enrollment.DTO
{
    public class StudentDTO : PersonDTO
    {
        public int Age { get; set; }
        public string? StudentNumber { get; set; }
        public MajorDTO? Major { get; set; }

    }
}