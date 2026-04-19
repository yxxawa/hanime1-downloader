using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Media;

namespace Hanime1Downloader.CSharp.Models;

public sealed class VideoSummary : INotifyPropertyChanged
{
    private ImageSource? _coverImage;

    public required string VideoId { get; init; }
    public required string Title { get; init; }
    public required string Url { get; init; }
    public string CoverUrl { get; init; } = string.Empty;

    public ImageSource? CoverImage
    {
        get => _coverImage;
        set
        {
            if (ReferenceEquals(_coverImage, value))
            {
                return;
            }

            _coverImage = value;
            OnPropertyChanged();
        }
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    public override string ToString() => $"[{VideoId}] {Title}";

    private void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
