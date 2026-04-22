namespace Hanime1Downloader.CSharp.Models;

public sealed class DownloadProbeResult
{
    public string ContentType { get; init; } = string.Empty;
    public long? ContentLength { get; init; }
    public bool IsPartial { get; init; }
}
