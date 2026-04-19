using System.IO;
using System.Windows;

namespace Hanime1Downloader.CSharp.Models;

public sealed class AppSettings
{
    public string DownloadPath { get; set; } = Path.Combine(AppContext.BaseDirectory, "downloads");
    public string FileNamingRule { get; set; } = "{title}";
    public bool ShowListCovers { get; set; } = true;
    public bool CompactMode { get; set; } = false;
    public string DefaultQuality { get; set; } = "highest";
    public string SiteHost { get; set; } = "hanime1.com";
    public bool PersistDownloadQueue { get; set; } = true;
    public List<string> SearchHistory { get; set; } = [];
    public VideoDetailsVisibilitySettings VideoDetailsVisibility { get; set; } = new();
    public PlayerWindowSettings PlayerWindow { get; set; } = new();

    public string SiteBaseUrl => $"https://{SiteHost}";
}

public sealed class VideoDetailsVisibilitySettings
{
    public bool Title { get; set; } = true;
    public bool UploadDate { get; set; } = true;
    public bool Likes { get; set; } = true;
    public bool Views { get; set; } = true;
    public bool Duration { get; set; } = true;
    public bool Tags { get; set; } = true;
    public bool Cover { get; set; } = true;
    public bool RelatedVideos { get; set; } = true;
}

public sealed class PlayerWindowSettings
{
    public double Width { get; set; } = 920;
    public double Height { get; set; } = 620;
    public double? Left { get; set; }
    public double? Top { get; set; }
    public WindowState WindowState { get; set; } = WindowState.Normal;
}
