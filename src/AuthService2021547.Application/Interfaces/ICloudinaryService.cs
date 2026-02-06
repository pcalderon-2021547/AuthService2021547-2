namespace AuthService2021547.Application.Interfaces;

public interface ICloudinaryService
{
    Task<string> UploadImageAsync(IFileData imageFile, string file);
    Task<bool> DeleteImageAsync(string publicId);
    string GetDefaultAvatarUrl();
    string GetFullImageUrl(string imagePath);
}