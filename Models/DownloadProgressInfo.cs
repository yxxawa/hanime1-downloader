namespace Hanime1Downloader.CSharp.Models;

public sealed class DownloadProgressInfo
{
    public long BytesReceived { get; init; }
    public long? TotalBytes { get; init; }
    public double BytesPerSecond { get; init; }
    public TimeSpan? EstimatedRemaining =>
        TotalBytes is > 0 && BytesPerSecond > 0 && BytesReceived < TotalBytes.Value
            ? TimeSpan.FromSeconds((TotalBytes.Value - BytesReceived) / BytesPerSecond)
            : null;
    public double? Percentage => TotalBytes is > 0 ? BytesReceived * 100d / TotalBytes.Value : null;
}
