namespace AuthService2021547.Application.Interface;

public interface ICloudinaryService
{
    Task<string> UploadImageAsync (IFileData imageFile, string filename);
    Task<bool> DeleteImageAsync(string publicId);
    string GetDefaultAvatarUrl();
    string GetFullImageUrl(string imagePath);
}