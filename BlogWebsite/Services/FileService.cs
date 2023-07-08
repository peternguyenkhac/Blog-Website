using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BlogWebsite.Services
{
    public class FileService
    {
        private readonly IWebHostEnvironment env;
        public FileService(IWebHostEnvironment env)
        {
            this.env = env;
        }
        public string Upload(IFormFile file)
        {
            var uploadDirecotroy = "uploads/";
            var uploadPath = Path.Combine(env.WebRootPath, uploadDirecotroy);
            var fileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
            var filePath = Path.Combine(uploadPath, fileName);
            using (var fileStream = new FileStream(filePath, FileMode.Create))
            {
                file.CopyTo(fileStream);
            }

            var urlImage = "/" + uploadDirecotroy + fileName;

            return urlImage;
        }
    }
}
