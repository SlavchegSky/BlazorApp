using Blazor.Data;
using Blazor.Models;
using BlazorInputFile;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor.Controller
{
    public class UploadFilesController : ControllerBase
    {
        private readonly SqlDbContext _context;
        private readonly IWebHostEnvironment _appEnvironment;

        public UploadFilesController(SqlDbContext context, IWebHostEnvironment appEnvironment)
        {
            _context = context;
            _appEnvironment = appEnvironment;
        }

        [HttpPost]
        public async Task<bool> UploadAsync(IFileListEntry fileEntry)
        {

            if (fileEntry != null)
            {
                var format = "image/jpeg";
                var imageFileMin = await fileEntry.ToImageFileAsync(format, 640, 480);
                var imageFileMax = await fileEntry.ToImageFileAsync(format, 1024, 768);
                var pathMin = Path.Combine(_appEnvironment.WebRootPath, "upload/images_min", fileEntry.Name);
                var pathMax = Path.Combine(_appEnvironment.WebRootPath, "upload/images_max", fileEntry.Name);

                var ms = new MemoryStream();
                await imageFileMin.Data.CopyToAsync(ms);
                using (FileStream fileStream = new FileStream(pathMin, FileMode.Create, FileAccess.Write))
                {
                    ms.WriteTo(fileStream);
                }
                ms.Dispose();
                ms = new MemoryStream();
                await imageFileMax.Data.CopyToAsync(ms);
                using (FileStream fileStream = new FileStream(pathMax, FileMode.Create, FileAccess.Write))
                {
                    ms.WriteTo(fileStream);
                }

                FileModel file = new FileModel { Name = fileEntry.Name, Path = "upload/images" };
                _context.Files.Add(file);
                _context.SaveChanges();

                return true;
            }
            return false;
        }

        public Task<List<FileModel>> ListAll()
        {
            var results = _context.Files;

            return Task.FromResult(results.ToList());
        }
    }
}
