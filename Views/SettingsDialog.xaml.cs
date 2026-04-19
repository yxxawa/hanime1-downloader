using Hanime1Downloader.CSharp.Models;
using Microsoft.Win32;
using System.Windows;

namespace Hanime1Downloader.CSharp.Views;

public partial class SettingsDialog : Window
{
    public AppSettings Settings { get; }

    public SettingsDialog(AppSettings currentSettings)
    {
        InitializeComponent();
        Settings = new AppSettings
        {
            DownloadPath = currentSettings.DownloadPath,
            FileNamingRule = currentSettings.FileNamingRule,
            ShowListCovers = currentSettings.ShowListCovers,
            CompactMode = currentSettings.CompactMode,
            DefaultQuality = currentSettings.DefaultQuality,
            SiteHost = currentSettings.SiteHost,
            PersistDownloadQueue = currentSettings.PersistDownloadQueue,
            SearchHistory = currentSettings.SearchHistory.ToList(),
            VideoDetailsVisibility = new VideoDetailsVisibilitySettings
            {
                Title = currentSettings.VideoDetailsVisibility.Title,
                UploadDate = currentSettings.VideoDetailsVisibility.UploadDate,
                Likes = currentSettings.VideoDetailsVisibility.Likes,
                Views = currentSettings.VideoDetailsVisibility.Views,
                Duration = currentSettings.VideoDetailsVisibility.Duration,
                Tags = currentSettings.VideoDetailsVisibility.Tags,
                Cover = currentSettings.VideoDetailsVisibility.Cover,
                RelatedVideos = currentSettings.VideoDetailsVisibility.RelatedVideos
            }
        };

        NamingRuleCombo.ItemsSource = new List<NamingRuleOption>
        {
            new() { Label = "标题", Value = "{title}" },
            new() { Label = "标题 + 画质", Value = "{title}_{quality}" },
            new() { Label = "标题 + 视频ID", Value = "{title}_{videoId}" },
            new() { Label = "标题 + 画质 + 时间", Value = "{title}_{quality}_{timestamp}" },
            new() { Label = "视频ID + 画质", Value = "{videoId}_{quality}" },
            new() { Label = "标题 + 时间", Value = "{title}_{timestamp}" },
            new() { Label = "时间", Value = "{timestamp}" }
        };

        SiteCombo.ItemsSource = new List<NamingRuleOption>
        {
            new() { Label = "hanime1.me", Value = "hanime1.me" },
            new() { Label = "hanime1.com", Value = "hanime1.com" },
            new() { Label = "hanimeone.me", Value = "hanimeone.me" },
            new() { Label = "javchu.com（暂不支持下载）", Value = "javchu.com" }
        };

        QualityCombo.ItemsSource = new List<NamingRuleOption>
        {
            new() { Label = "最高画质", Value = "highest" },
            new() { Label = "720p", Value = "720" },
            new() { Label = "480p", Value = "480" },
            new() { Label = "最低画质", Value = "lowest" }
        };

        DownloadPathBox.Text = Settings.DownloadPath;
        NamingRuleCombo.SelectedValue = Settings.FileNamingRule;
        SiteCombo.SelectedValue = Settings.SiteHost;
        QualityCombo.SelectedValue = Settings.DefaultQuality;
        ShowListCoversCheckBox.IsChecked = Settings.ShowListCovers;
        CompactModeCheckBox.IsChecked = Settings.CompactMode;
        PersistQueueCheckBox.IsChecked = Settings.PersistDownloadQueue;
        ShowTitleCheckBox.IsChecked = Settings.VideoDetailsVisibility.Title;
        ShowUploadDateCheckBox.IsChecked = Settings.VideoDetailsVisibility.UploadDate;
        ShowLikesCheckBox.IsChecked = Settings.VideoDetailsVisibility.Likes;
        ShowViewsCheckBox.IsChecked = Settings.VideoDetailsVisibility.Views;
        ShowDurationCheckBox.IsChecked = Settings.VideoDetailsVisibility.Duration;
        ShowTagsCheckBox.IsChecked = Settings.VideoDetailsVisibility.Tags;
        ShowCoverCheckBox.IsChecked = Settings.VideoDetailsVisibility.Cover;
        ShowRelatedVideosCheckBox.IsChecked = Settings.VideoDetailsVisibility.RelatedVideos;
        if (NamingRuleCombo.SelectedIndex < 0)
        {
            NamingRuleCombo.SelectedIndex = 0;
        }
    }

    private void BrowseButton_OnClick(object sender, RoutedEventArgs e)
    {
        var dialog = new OpenFolderDialog
        {
            FolderName = DownloadPathBox.Text
        };
        if (dialog.ShowDialog() == true)
        {
            DownloadPathBox.Text = dialog.FolderName;
        }
    }

    private void ConfirmButton_OnClick(object sender, RoutedEventArgs e)
    {
        Settings.DownloadPath = string.IsNullOrWhiteSpace(DownloadPathBox.Text) ? Settings.DownloadPath : DownloadPathBox.Text.Trim();
        Settings.FileNamingRule = NamingRuleCombo.SelectedValue as string ?? "{title}";
        Settings.SiteHost = SiteCombo.SelectedValue as string ?? "hanime1.com";
        Settings.DefaultQuality = QualityCombo.SelectedValue as string ?? "highest";
        Settings.ShowListCovers = ShowListCoversCheckBox.IsChecked == true;
        Settings.CompactMode = CompactModeCheckBox.IsChecked == true;
        Settings.PersistDownloadQueue = PersistQueueCheckBox.IsChecked == true;
        Settings.VideoDetailsVisibility.Title = ShowTitleCheckBox.IsChecked == true;
        Settings.VideoDetailsVisibility.UploadDate = ShowUploadDateCheckBox.IsChecked == true;
        Settings.VideoDetailsVisibility.Likes = ShowLikesCheckBox.IsChecked == true;
        Settings.VideoDetailsVisibility.Views = ShowViewsCheckBox.IsChecked == true;
        Settings.VideoDetailsVisibility.Duration = ShowDurationCheckBox.IsChecked == true;
        Settings.VideoDetailsVisibility.Tags = ShowTagsCheckBox.IsChecked == true;
        Settings.VideoDetailsVisibility.Cover = ShowCoverCheckBox.IsChecked == true;
        Settings.VideoDetailsVisibility.RelatedVideos = ShowRelatedVideosCheckBox.IsChecked == true;
        DialogResult = true;
    }

    private sealed class NamingRuleOption
    {
        public required string Label { get; init; }
        public required string Value { get; init; }
    }
}
