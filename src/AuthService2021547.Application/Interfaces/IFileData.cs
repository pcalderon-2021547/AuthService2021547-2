namespace AuthService2021547.Application.Interfaces;

public interface IFileData
{
    byte[] Data { get; }
    string ContentType { get; }
    string FileName { get; }
    long Size { get; }
}