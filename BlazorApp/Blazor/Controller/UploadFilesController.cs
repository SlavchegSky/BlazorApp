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
                var path = Path.Combine(_appEnvironment.WebRootPath, "upload/images", fileEntry.Name);
                var ms = new MemoryStream();
                await fileEntry.Data.CopyToAsync(ms);
                using (FileStream fileStream = new FileStream(path, FileMode.Create, FileAccess.Write))
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
