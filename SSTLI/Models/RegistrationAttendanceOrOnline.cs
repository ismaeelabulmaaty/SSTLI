using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SSTLI.Models
{
    public class RegistrationAttendanceOrOnline
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string NationalIdNumber { get; set; }
        public string City { get; set; }
        public string Branch { get; set; }
        public string Batch { get; set; }
        public AttendanceType AttendanceType { get; set; }
        public QualificationType QualificationType { get; set; }
        public string? EducationalQualification { get; set; }
        public string? Message { get; set; }
        public string? attachNationalIdImage { get; set; }
        public string? AttachEducationalQualificationImage { get; set; }
        public string? Signature { get; set; }
    }
}
