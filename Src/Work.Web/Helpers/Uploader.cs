using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Work.Web.ViewModels;

namespace Work.Web.Helpers
{
    public static class Uploader
    {
        public static string UploadedFile(IFormFile image,string path, IWebHostEnvironment  env)
        {
            string uniqueFileName = null;

            if (image != null)
            {
                string uploadsFolder = Path.Combine(env.WebRootPath, path);
                uniqueFileName = Guid.NewGuid() + "_" + image.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using var fs = File.Create(filePath);
                image.CopyTo(fs);
                fs.Flush();
            }
            return uniqueFileName;
        }
    }

}
