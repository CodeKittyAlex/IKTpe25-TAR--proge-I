using University.Dto;
using University.Models;

namespace University.ServicesInterface
{
    public interface IFileservises
    {
        void FilesToApi(CourseDto dto, Course domain);
        Task<FileToApi?> RemoveImageFromApi(FileToApiDto dto);
    }
}
