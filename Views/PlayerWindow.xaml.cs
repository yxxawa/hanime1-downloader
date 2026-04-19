using Hanime1Downloader.CSharp.Models;
using Microsoft.Web.WebView2.Core;
using System.IO;
using System.Text.Json;
using System.Windows;

namespace Hanime1Downloader.CSharp.Views;

public partial class PlayerWindow : Window
{
    private static readonly string WebViewUserDataFolder = Path.Combine(
        Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
        "Hanime1Downloader.CSharp",
        "WebView2",
        "player");

    private readonly AppSettings _settings;
    private bool _isBrowserReady;
    private string _currentVideoUrl = string.Empty;

    public PlayerWindow(AppSettings settings)
    {
        _settings = settings;
        InitializeComponent();
        ShowActivated = true;
        Loaded += OnLoaded;
        Closing += OnClosing;
        Closed += OnClosed;
    }

    public async Task OpenAsync(string title, string videoUrl, string type)
    {
        Title = string.IsNullOrWhiteSpace(title) ? "播放" : $"播放 - {title}";
        TitleText.Text = string.IsNullOrWhiteSpace(title) ? "正在加载播放器..." : title;
        _currentVideoUrl = videoUrl;
        Show();
        Activate();
        Focus();

        if (!_isBrowserReady)
        {
            Directory.CreateDirectory(WebViewUserDataFolder);
            var environment = await CoreWebView2Environment.CreateAsync(userDataFolder: WebViewUserDataFolder);
            await Browser.EnsureCoreWebView2Async(environment);
            Browser.CoreWebView2.Settings.AreDevToolsEnabled = false;
            Browser.CoreWebView2.Settings.AreDefaultContextMenusEnabled = true;
            _isBrowserReady = true;
        }

        var encodedUrl = JsonSerializer.Serialize(videoUrl);
        var mimeType = type.Contains("m3u8", StringComparison.OrdinalIgnoreCase)
            ? "application/vnd.apple.mpegurl"
            : "video/mp4";

        Browser.NavigateToString($"<!DOCTYPE html><html><head><meta charset=\"utf-8\" /><meta name=\"viewport\" content=\"width=device-width, initial-scale=1\" /><style>html, body {{ margin: 0; padding: 0; width: 100%; height: 100%; background: #000; overflow: hidden; }} video {{ width: 100%; height: 100%; background: #000; }}</style></head><body><video controls autoplay playsinline><source src={encodedUrl} type=\"{mimeType}\"></video></body></html>");
        TitleText.Text = string.IsNullOrWhiteSpace(title) ? "播放" : title;
    }

    private void OnLoaded(object sender, RoutedEventArgs e)
    {
        var state = _settings.PlayerWindow;
        Width = state.Width > MinWidth ? state.Width : Width;
        Height = state.Height > MinHeight ? state.Height : Height;
        if (state.Left.HasValue && state.Top.HasValue && double.IsFinite(state.Left.Value) && double.IsFinite(state.Top.Value))
        {
            Left = state.Left.Value;
            Top = state.Top.Value;
            WindowStartupLocation = WindowStartupLocation.Manual;
        }
        WindowState = state.WindowState;
    }

    private void OnClosing(object? sender, System.ComponentModel.CancelEventArgs e)
    {
        var state = _settings.PlayerWindow;
        state.WindowState = Enum.IsDefined(WindowState) ? WindowState : WindowState.Normal;

        var width = WindowState == WindowState.Normal ? Width : RestoreBounds.Width;
        var height = WindowState == WindowState.Normal ? Height : RestoreBounds.Height;
        var left = WindowState == WindowState.Normal ? Left : RestoreBounds.Left;
        var top = WindowState == WindowState.Normal ? Top : RestoreBounds.Top;

        state.Width = double.IsFinite(width) && width > 0 ? width : 920;
        state.Height = double.IsFinite(height) && height > 0 ? height : 620;
        state.Left = double.IsFinite(left) ? left : null;
        state.Top = double.IsFinite(top) ? top : null;

        StopPlayback();
    }

    private void OnClosed(object? sender, EventArgs e)
    {
        if (!_isBrowserReady)
        {
            return;
        }

        try
        {
            Browser.Dispose();
        }
        catch
        {
        }
    }

    private void StopPlayback()
    {
        if (!_isBrowserReady)
        {
            return;
        }

        try
        {
            if (Browser.CoreWebView2 is not null)
            {
                _ = Browser.CoreWebView2.ExecuteScriptAsync("document.querySelectorAll('video,audio').forEach(el => { try { el.pause(); el.removeAttribute('src'); if (typeof el.load === 'function') { el.load(); } } catch {} }); if (document.body) { document.body.innerHTML = ''; }");
                Browser.CoreWebView2.Stop();
            }

            Browser.NavigateToString("<!DOCTYPE html><html><body style=\"margin:0;background:#000;\"></body></html>");
        }
        catch
        {
        }
    }

    private void CopyLinkButton_OnClick(object sender, RoutedEventArgs e)
    {
        if (string.IsNullOrWhiteSpace(_currentVideoUrl))
        {
            return;
        }

        Clipboard.SetText(_currentVideoUrl);
    }
}
