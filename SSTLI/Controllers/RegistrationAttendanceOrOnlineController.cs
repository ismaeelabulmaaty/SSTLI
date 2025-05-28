using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SSTLI.Dtos;
using SSTLI.Helper;
using SSTLI.Interface;
using SSTLI.Models;

namespace SSTLI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RegistrationAttendanceOrOnlineController : ControllerBase
    {

        private readonly IRegistrationRepository _repo;

        public RegistrationAttendanceOrOnlineController(IRegistrationRepository repo)
        {
            _repo = repo;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromForm] RegistrationCreateDto model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(new
                    {
                        Success = false,
                        Message = "البيانات غير صحيحة",
                        Errors = ModelState.Values.SelectMany(v => v.Errors.Select(e => e.ErrorMessage)).ToList()
                    });
                }

                var registration = new RegistrationAttendanceOrOnline
                {
                    Name = model.Name,
                    Email = model.Email,
                    PhoneNumber = model.PhoneNumber,
                    NationalIdNumber = model.NationalIdNumber,
                    City = model.City,
                    Branch = model.Branch,
                    Batch = model.Batch,
                    AttendanceType = model.AttendanceType,
                    QualificationType = model.QualificationType,
                    EducationalQualification = model.EducationalQualification,
                    Message = model.Message,

                };

                registration.attachNationalIdImage = await Base64File.ConvertFileToBase64SafeAsync(model.AttachNationalIdImage);
                registration.AttachEducationalQualificationImage = await Base64File.ConvertFileToBase64SafeAsync(model.AttachEducationalQualificationImage);
                registration.Signature = await Base64File.ConvertFileToBase64SafeAsync(model.Signature);


                await _repo.AddAsync(registration);
                await _repo.SaveChangesAsync();

                #region ConvertAsString
                //if (model.AttachNationalIdPhoto != null)
                //{
                //    try
                //    {
                //        registration.attachNationalIdPhoto = DocumentSetting.UploadFile(model.AttachNationalIdPhoto, "NationalNumber);
                //    }
                //    catch (Exception ex)
                //    {
                //        return BadRequest(new
                //        {
                //            Success = false,
                //            Message = "فشل في رفع صورة الهوية الوطنية",
                //            Errors = new List<string> { ex.Message }
                //        });
                //    }
                //}

                //if (model.AttachEducationalQualification != null)
                //{
                //    try
                //    {
                //        registration.AttachEducationalQualification = DocumentSetting.UploadFile(model.AttachEducationalQualification, "Educational");
                //    }
                //    catch (Exception ex)
                //    {
                //        if (!string.IsNullOrEmpty(registration.attachNationalIdPhoto))
                //        {
                //            DocumentSetting.DeleteFile("NationalNumber", registration.attachNationalIdPhoto);
                //        }

                //        return BadRequest(new
                //        {
                //            Success = false,
                //            Message = "فشل في رفع شهادة المؤهل التعليمي",
                //            Errors = new List<string> { ex.Message }
                //        });
                //    }
                //}

                //if (model.Signature != null)
                //{
                //    try
                //    {
                //        registration.Signature = DocumentSetting.UploadFile(model.Signature, "Signature");
                //    }
                //    catch (Exception ex)
                //    {
                //        if (!string.IsNullOrEmpty(registration.attachNationalIdPhoto))
                //        {
                //            DocumentSetting.DeleteFile("NationalNumber", registration.attachNationalIdPhoto);
                //        }

                //        return BadRequest(new
                //        {
                //            Success = false,
                //            Message = "فشل في رفع التوقيع",
                //            Errors = new List<string> { ex.Message }
                //        });
                //    }
                //}

                #endregion

                var response = new RegistrationResponseDto
                {
                    Id = registration.Id,
                    Name = registration.Name,
                    Email = registration.Email,
                    PhoneNumber = registration.PhoneNumber,
                    NationalIdNumber = registration.NationalIdNumber,
                    City = registration.City,
                    Branch = registration.Branch,
                    Batch = registration.Batch,
                    AttendanceType = registration.AttendanceType.ToString(),
                    QualificationType = registration.QualificationType.ToString(),
                    EducationalQualification = registration.EducationalQualification,
                    Message = registration.Message,
                    AttachNationalIdImage = registration.attachNationalIdImage,
                    AttachEducationalQualificationImage = registration.AttachEducationalQualificationImage,
                    Signature = registration.Signature,
                };

                return Ok(new
                {
                    Success = true,
                    Message = "تم إنشاء التسجيل بنجاح",
                    Data = response
                });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new
                {
                    Success = false,
                    Message = "حدث خطأ في الخادم",
                    Errors = new List<string> { ex.Message }
                });
            }
        }




    }
}
