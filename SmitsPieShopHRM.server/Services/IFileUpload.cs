using BlazorInputFile;
using System.Threading.Tasks;

namespace SmitsPieShopHRM.server.Services
{
    public interface IFileUpload
    {
        Task UploadAsync(IFileListEntry file);
    }
}
