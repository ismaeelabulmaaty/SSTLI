using SSTLI.Models;

namespace SSTLI.Dtos
{
    public class RegistrationResponseDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string NationalIdNumber { get; set; }
        public string City { get; set; }
        public string Branch { get; set; }
        public string Batch { get; set; }
        public string AttendanceType { get; set; }
        public string QualificationType { get; set; }
        public string? EducationalQualification { get; set; }
        public string Message { get; set; }
        public string AttachNationalIdImage{ get; set; }
        public string AttachEducationalQualificationImage { get; set; }
        public string Signature { get; set; }
    }
}
