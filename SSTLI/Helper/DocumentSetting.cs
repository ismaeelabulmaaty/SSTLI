namespace SSTLI.Helper
{
    public class DocumentSetting
    {
        public static string UploadFile(IFormFile file, string folderName)
        {

            var folderPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Files", folderName);

            if (!Directory.Exists(folderPath))
                Directory.CreateDirectory(folderPath);


            var fileName = $"{Guid.NewGuid()}-{Path.GetExtension(file.FileName)}";


            var filePath = Path.Combine(folderPath, fileName);


            using var fileStream = new FileStream(filePath, FileMode.Create);
            file.CopyTo(fileStream);

            return fileName;

        }

        public static void DeleteFile(string folderName, string fileName)
        {
            var folderPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Files", folderName, fileName);

            if (File.Exists(folderPath))
            {
                File.Delete(folderPath);
            }
        }
        public static string UpdateFile(IFormFile file, string folderName, string fileName)
        {
            DeleteFile(folderName, fileName);

            return UploadFile(file, folderName);
        }
    }
}
