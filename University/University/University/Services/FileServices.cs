using Microsoft.EntityFrameworkCore;
using University.Data;
using University.Dto;
using University.Models;
using University.ServicesInterface;

namespace University.Services
{
    public class FileServices : IFileservises
    {
        private readonly IHostEnvironment _webHost;
        private readonly UniversityContext _context;
        public FileServices
            (
                IHostEnvironment webHost,
                UniversityContext context
            )
        {
            _webHost = webHost;
            _context = context;
        }
        

        public void FilesToApi(CourseDto dto, Course domain)
        {
            if (dto.Files != null && dto.Files.Count > 0)
            {
                if(!Directory.Exists(_webHost.ContentRootPath + "\\wwwroot\\MultipleFileUpload\\"))
                {
                    Directory.CreateDirectory(_webHost.ContentRootPath + "\\wwwroot\\MultipleFileUpload\\");
                }

                foreach (var file in dto.Files)
                {
                    string uploadsFolder = Path.Combine(_webHost.ContentRootPath, "wwwroot", "MultipleFileUpload");
                    string uniqueFileName = Guid.NewGuid().ToString() + " - " + file.FileName;
                    string filePath = Path.Combine(uploadsFolder, uniqueFileName);

                    using(var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        file.CopyTo(fileStream);

                        FileToApi path = new FileToApi
                        {
                            Id = Guid.NewGuid(),
                            ExistingFilePath = uniqueFileName,
                            CourseId = domain.CourseId
                        };
                        _context.FileToApis.Add(path);
                    }
                }
            }
        }
        public async Task<FileToApi?> RemoveImageFromApi(FileToApiDto dto)
        {
            //kui soovin kustudada siis pean läbi id pildi üles otsima
            var imageId = await _context.FileToApis
                .FirstOrDefaultAsync(x => x.Id == dto.Id);

            //nüüd otsime faili ülesse apis ja see kustutakse ära
            var filePath = _webHost.ContentRootPath + "\\wwwroot\\MultipleFileUpload\\"
                + imageId.ExistingFilePath;
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }

            _context.FileToApis.Remove(imageId);
            await _context.SaveChangesAsync();

            return null;
        }
    }
}
