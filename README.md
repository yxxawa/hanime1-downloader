# Hanime1Downloader.CSharp
qq反馈吹水群1102413927   
完全重构修复了下（小声吐槽句，win11的控制栏真难看）    
一个基于 WPF 和 .NET 9 的桌面工具，用于搜索、查看详情、获取hanime1视频源并管理下载队列。

## 界面   
<img width="1711" height="1081" alt="QQ20260421-215700" src="https://github.com/user-attachments/assets/f95681a9-dc23-4fb9-bb7b-ed99afc53b0b" />

深色模式
<img width="1711" height="1079" alt="QQ20260421-215644" src="https://github.com/user-attachments/assets/31c3e4c3-ae8d-4ad7-88eb-68a645715251" />

精简模式   
<img width="1714" height="1077" alt="QQ20260421-215800" src="https://github.com/user-attachments/assets/a87d7e28-7fca-4c24-aef1-142fa0ce4022" />


## 当前功能

- 搜索视频
- 按条件筛选搜索结果
- 查看视频详情、简介、标签与相关视频
- 获取不同清晰度的视频源
- 复制视频源链接或在浏览器中打开
- 使用内置播放器窗口播放视频源
- 单个下载与下载队列管理
- 失败任务重新解析
- 下载历史记录
- 收藏夹新建、重命名、删除、导入、导出
- Cloudflare 验证会话复用
- 列表封面显示与缩略图缓存
- 明暗主题切换
- 精简模式
- 自定义详情面板显示项
- 自定义站点域名

## 运行环境

### 开发运行

- Windows
- .NET 9 SDK
- WebView2 Runtime

### 发布后的程序运行

- Windows x64
- .NET 9 Desktop Runtime
- WebView2 Runtime

## 构建

```bash
dotnet build "Hanime1Downloader.CSharp.csproj"
```

## 运行

```bash
dotnet run --project "Hanime1Downloader.CSharp.csproj"
```

## 发布

项目当前已配置为单文件发布、`win-x64`、非自包含：

```bash
dotnet publish "Hanime1Downloader.CSharp.csproj" -c Release -p:DebugType=None -p:DebugSymbols=false
```

发布产物默认会生成到：

```text
bin/Release/net9.0-windows/win-x64/publish/
```

## 配置与数据文件

程序当前将配置和运行数据保存在 exe 同目录，便于直接打包和迁移：

- `settings.json`：程序设置
- `favorites.json`：收藏夹数据
- `download_history.json`：下载历史
- `download_queue.json`：下载队列
- `cookies.json`：Cloudflare 会话缓存
- `Downloads/`：默认下载目录

## 设置项概览

当前设置窗口包含以下内容：

- 默认画质
- 最大同时下载任务数
- 访问站点与自定义站点管理
- 下载队列是否在关闭程序后保留
- 保存路径
- 文件命名规则
- 明暗主题切换
- 列表封面显示
- 精简模式
- 详情面板显示项开关

## 项目结构

- `MainWindow.xaml` / `MainWindow.xaml.cs`：主界面、搜索流程、详情展示、下载队列、收藏夹、历史记录等主逻辑
- `Views/`：设置窗口、筛选窗口、Cloudflare 验证窗口、播放器窗口、多选窗口、输入窗口
- `Services/`：站点访问、Cloudflare Cookie 桥接、HTTP 客户端、下载、日志、主题、缩略图缓存等服务
- `Models/`：应用设置、视频信息、下载信息、搜索结果等数据模型
- `Assets/`：筛选项等内置静态资源
- `Themes/`：浅色与深色主题资源
- `Converters/`：界面绑定转换器

