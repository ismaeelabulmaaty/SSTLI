namespace SSTLI.Helper
{
    public class Base64File
    {
        public static async Task<string> ConvertFileToBase64Async(IFormFile file)
        {
            if (file == null || file.Length == 0)
            {
                return $"الملف غير موجود";
            }
            try
            {

                using var memoryStream = new MemoryStream();
                await file.CopyToAsync(memoryStream);
                byte[] fileBytes = memoryStream.ToArray();

                if (fileBytes == null || fileBytes.Length == 0)
                {
                    return $"الملف فارغ";
                }

                string base64String = Convert.ToBase64String(fileBytes);

                return base64String;

            }
            catch (Exception ex)
            {
                throw new Exception($"خطأ في تحويل الملف: {ex.Message}");
            }

        }



        public static async Task<string> ConvertFileToBase64SafeAsync(IFormFile file)
        {
            if (file == null)
            {
                return $"الملف غير موجود";
            }

            if (file.Length == 0)
            {
                return $"الملف المرفوع فارغ";
            }


            var result = await Base64File.ConvertFileToBase64Async(file);


            return result;
        }
    }
}
