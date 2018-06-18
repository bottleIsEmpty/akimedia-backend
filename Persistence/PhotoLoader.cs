using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace akimedia_server.Persistence
{
    public class PhotoLoader
    {
        static public async Task<string> addPhoto(string type, IFormFile photo, string webRootPath) 
        {
            var uploadsFolderPath = Path.Combine(webRootPath, "photos");

            switch(type) 
            {
                case "film":
                    uploadsFolderPath = Path.Combine(uploadsFolderPath, "films/films"); 
                    break;
                case "film-director":
                    uploadsFolderPath = Path.Combine(uploadsFolderPath, "films/directors"); 
                    break;
                case "book":
                    uploadsFolderPath = Path.Combine(uploadsFolderPath, "books/books"); 
                    break;
                case "book-author":
                    uploadsFolderPath = Path.Combine(uploadsFolderPath, "books/authors"); 
                    break;
                case "music":
                    uploadsFolderPath = Path.Combine(uploadsFolderPath, "music/music"); 
                    break;
                case "music-composer":
                    uploadsFolderPath = Path.Combine(uploadsFolderPath, "music/composers"); 
                    break;
                default:
                    return null;
            }

            if (!Directory.Exists(uploadsFolderPath))
                Directory.CreateDirectory(uploadsFolderPath);

            var fileName = System.Guid.NewGuid().ToString() + Path.GetExtension(photo.FileName);
            var filePath = Path.Combine(uploadsFolderPath, fileName);

            using (var stream = new FileStream(filePath, FileMode.Create)) 
            {
                await photo.CopyToAsync(stream);
            }

            return fileName;
            
        } 
    }
}