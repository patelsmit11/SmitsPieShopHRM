using BlazorInputFile;
using Microsoft.AspNetCore.Hosting;
using System;
using System.IO;
using System.Threading.Tasks;

namespace SmitsPieShopHRM.server.Services
{
    public class FileUpload : IFileUpload
    {
        private readonly IWebHostEnvironment _environment;
        public FileUpload(IWebHostEnvironment environment)
        {
            _environment = environment;
        }
        public async Task UploadAsync(IFileListEntry file)
        {
            try
            {
                var path = Path.Combine(_environment.ContentRootPath, "wwwroot", "EmployeePhotos", file.Name);
                var ms = new MemoryStream();
                await file.Data.CopyToAsync(ms);
                using FileStream fileEntry = new FileStream(path, FileMode.Create, FileAccess.Write);
                ms.WriteTo(fileEntry);
            }
            catch (Exception ex)
            {
            }
        }
    }
}
