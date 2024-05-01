using System.IO.Compression;

namespace DHL_API_READER
{
    public class Extract
    {
        public static void Zip(string base64Zip)
        {
            string extractPath = @"C:\temp\DHL";

            byte[] zipBytes = Convert.FromBase64String(base64Zip);
            using var memoryStream = new MemoryStream(zipBytes);
            using var archive = new ZipArchive(memoryStream, ZipArchiveMode.Read);
            archive.ExtractToDirectory(extractPath);
        }

        public static void PDF(string base64)
        {
            string extractPath = @"C:\temp\DHL\test.pdf";

            byte[] zipBytes = Convert.FromBase64String(base64);
            using var memoryStream = new MemoryStream(zipBytes);
            File.WriteAllBytes(extractPath, zipBytes);
        }
    }
}
