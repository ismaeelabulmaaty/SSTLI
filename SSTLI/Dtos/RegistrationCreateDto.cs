using SSTLI.Models;
using System.ComponentModel.DataAnnotations;

namespace SSTLI.Dtos
{
    public class RegistrationCreateDto
    {
        public string Name { get; set; }

        [Required(ErrorMessage = "البريد الإلكتروني مطلوب")]
        [EmailAddress(ErrorMessage = "البريد الإلكتروني غير صحيح")]
        public string Email { get; set; }

        [Required(ErrorMessage = "رقم الهاتف مطلوب")]
       [RegularExpression(@"^05[0-9]{8}$", ErrorMessage = "رقم الهاتف يجب أن يبدأ بـ 05 ويكون 10 أرقام")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "رقم الهوية الوطنية مطلوب")]
        [RegularExpression(@"^[1][0-9]{9}$", ErrorMessage = "رقم الهوية الوطنية يجب أن يكون 10 أرقام ويبدأ بـ 1")]
        public string NationalIdNumber { get; set; }
        public string City { get; set; }
        public string Branch { get; set; }
        public DateTime Batch { get; set; }
        public AttendanceType AttendanceType { get; set; }
        public QualificationType QualificationType { get; set; }
        public string EducationalQualification { get; set; }
        public string? Message { get; set; }
        public IFormFile? AttachNationalIdImage { get; set; }
        public IFormFile? AttachEducationalQualificationImage { get; set; }
        public IFormFile? Signature { get; set; }
    }

}
