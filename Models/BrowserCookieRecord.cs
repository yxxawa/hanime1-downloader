namespace Hanime1Downloader.CSharp.Models;

public sealed class BrowserCookieRecord
{
    public required string Name { get; set; }
    public required string Value { get; set; }
    public string Domain { get; set; } = ".hanime1.me";
    public string Path { get; set; } = "/";
    public bool IsSecure { get; set; }
    public bool IsHttpOnly { get; set; }
}
