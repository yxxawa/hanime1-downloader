<!-- 顶部动态横幅 -->
<p align="center">
  <img src="https://capsule-render.vercel.app/api?type=waving&color=ff6b9d:a29bfe,100:74b9ff&height=200&section=header&text=Hanime1%20Downloader&fontSize=50&fontColor=fff&animation=fadeIn&fontAlignY=35&desc=基于%20WPF%20+%20.NET%209%20的二次元视频下载工具&descAlignY=55&descSize=15" width="100%"/>
</p>

<!-- SVG 二次元美少女背景标题区 -->
<div align="center">

<svg width="800" height="400" viewBox="0 0 800 400" xmlns="http://www.w3.org/2000/svg" style="max-width: 100%; border-radius: 20px; box-shadow: 0 8px 32px rgba(255,107,157,0.2);">
  <defs>
    <!-- 粉紫渐变背景 -->
    <linearGradient id="bgGrad" x1="0%" y1="0%" x2="100%" y2="100%">
      <stop offset="0%" style="stop-color:#fff0f5;stop-opacity:1" />
      <stop offset="50%" style="stop-color:#ffeef8;stop-opacity:1" />
      <stop offset="100%" style="stop-color:#f0e6ff;stop-opacity:1" />
    </linearGradient>
    
    <!-- 头发渐变 -->
    <linearGradient id="hairGrad" x1="0%" y1="0%" x2="100%" y2="100%">
      <stop offset="0%" style="stop-color:#ff8fab;stop-opacity:1" />
      <stop offset="100%" style="stop-color:#c77dff;stop-opacity:1" />
    </linearGradient>
    
    <!-- 皮肤渐变 -->
    <linearGradient id="skinGrad" x1="0%" y1="0%" x2="0%" y2="100%">
      <stop offset="0%" style="stop-color:#ffeadd;stop-opacity:1" />
      <stop offset="100%" style="stop-color:#ffd6c2;stop-opacity:1" />
    </linearGradient>
    
    <!-- 眼睛渐变 -->
    <radialGradient id="eyeGrad" cx="50%" cy="50%" r="50%">
      <stop offset="0%" style="stop-color:#7b2cbf;stop-opacity:1" />
      <stop offset="70%" style="stop-color:#c77dff;stop-opacity:1" />
      <stop offset="100%" style="stop-color:#e0aaff;stop-opacity:1" />
    </radialGradient>
    
    <!-- 腮红 -->
    <radialGradient id="blushGrad" cx="50%" cy="50%" r="50%">
      <stop offset="0%" style="stop-color:#ff6b9d;stop-opacity:0.4" />
      <stop offset="100%" style="stop-color:#ff6b9d;stop-opacity:0" />
    </radialGradient>
    
    <!-- 衣服渐变 -->
    <linearGradient id="clothesGrad" x1="0%" y1="0%" x2="100%" y2="100%">
      <stop offset="0%" style="stop-color:#a29bfe;stop-opacity:1" />
      <stop offset="100%" style="stop-color:#74b9ff;stop-opacity:1" />
    </linearGradient>
    
    <!-- 蝴蝶结渐变 -->
    <linearGradient id="bowGrad" x1="0%" y1="0%" x2="100%" y2="100%">
      <stop offset="0%" style="stop-color:#ff6b9d;stop-opacity:1" />
      <stop offset="100%" style="stop-color:#ff8fab;stop-opacity:1" />
    </linearGradient>
    
    <!-- 星星发光 -->
    <filter id="glow">
      <feGaussianBlur stdDeviation="2" result="coloredBlur"/>
      <feMerge>
        <feMergeNode in="coloredBlur"/>
        <feMergeNode in="SourceGraphic"/>
      </feMerge>
    </filter>
  </defs>
  
  <!-- 背景 -->
  <rect width="800" height="400" fill="url(#bgGrad)" rx="20"/>
  
  <!-- 背景装饰星星 -->
  <g fill="#ffd6e0" opacity="0.6">
    <circle cx="100" cy="80" r="3" filter="url(#glow)"/>
    <circle cx="700" cy="120" r="2" filter="url(#glow)"/>
    <circle cx="150" cy="300" r="2.5" filter="url(#glow)"/>
    <circle cx="720" cy="280" r="3" filter="url(#glow)"/>
    <circle cx="50" cy="200" r="2" filter="url(#glow)"/>
    <circle cx="750" cy="80" r="2.5" filter="url(#glow)"/>
    <path d="M 200 60 L 202 65 L 207 65 L 203 68 L 205 73 L 200 70 L 195 73 L 197 68 L 193 65 L 198 65 Z" fill="#ffd6e0" opacity="0.8"/>
    <path d="M 650 90 L 652 95 L 657 95 L 653 98 L 655 103 L 650 100 L 645 103 L 647 98 L 643 95 L 648 95 Z" fill="#ffd6e0" opacity="0.8"/>
    <path d="M 120 250 L 122 255 L 127 255 L 123 258 L 125 263 L 120 260 L 115 263 L 117 258 L 113 255 L 118 255 Z" fill="#ffd6e0" opacity="0.6"/>
  </g>
  
  <!-- 背景爱心 -->
  <g opacity="0.15" fill="#ff6b9d">
    <path d="M 680 200 C 680 185, 665 175, 650 190 C 635 175, 620 185, 620 200 C 620 220, 650 240, 650 240 C 650 240, 680 220, 680 200 Z" transform="scale(0.8) translate(150, 50)"/>
    <path d="M 200 150 C 200 140, 190 133, 180 143 C 170 133, 160 140, 160 150 C 160 163, 180 177, 180 177 C 180 177, 200 163, 200 150 Z" transform="scale(0.6) translate(100, 100)"/>
  </g>
  
  <!-- 美少女主体 -->
  <g transform="translate(400, 220)">
    <!-- 后发（双马尾） -->
    <path d="M -80 -80 Q -120 -20 -100 80 Q -90 120 -70 100 Q -60 80 -70 40 Q -80 0 -70 -40 Z" fill="url(#hairGrad)" opacity="0.9"/>
    <path d="M 80 -80 Q 120 -20 100 80 Q 90 120 70 100 Q 60 80 70 40 Q 80 0 70 -40 Z" fill="url(#hairGrad)" opacity="0.9"/>
    
    <!-- 身体/衣服 -->
    <path d="M -45 20 Q -55 60 -50 100 Q -40 130 -30 140 L 30 140 Q 40 130 50 100 Q 55 60 45 20 Z" fill="url(#clothesGrad)"/>
    
    <!-- 衣领 -->
    <path d="M -45 20 Q 0 35 45 20 Q 0 50 -45 20 Z" fill="#fff" opacity="0.9"/>
    
    <!-- 领结 -->
    <path d="M -15 25 L -25 35 L -15 40 L -5 35 Z" fill="url(#bowGrad)"/>
    <path d="M 15 25 L 25 35 L 15 40 L 5 35 Z" fill="url(#bowGrad)"/>
    <circle cx="0" cy="32" r="6" fill="url(#bowGrad)"/>
    
    <!-- 脖子 -->
    <rect x="-12" y="-10" width="24" height="35" fill="url(#skinGrad)" rx="5"/>
    
    <!-- 脸型 -->
    <path d="M -55 -60 Q -60 0 -35 40 Q 0 55 35 40 Q 60 0 55 -60 Q 0 -75 -55 -60 Z" fill="url(#skinGrad)"/>
    
    <!-- 前发（刘海） -->
    <path d="M -55 -60 Q -50 -30 -45 -10 Q -40 -40 -30 -15 Q -25 -45 -15 -10 Q -10 -40 0 -15 Q 10 -40 15 -10 Q 25 -45 30 -15 Q 40 -40 45 -10 Q 50 -30 55 -60 Q 0 -85 -55 -60 Z" fill="url(#hairGrad)"/>
    
    <!-- 呆毛 -->
    <path d="M 0 -70 Q 5 -95 15 -90 Q 5 -85 0 -70 Z" fill="url(#hairGrad)"/>
    
    <!-- 眼睛（左眼） -->
    <g transform="translate(-22, -5)">
      <!-- 眼眶 -->
      <ellipse cx="0" cy="0" rx="14" ry="16" fill="#fff"/>
      <!-- 眼球 -->
      <ellipse cx="0" cy="2" rx="10" ry="12" fill="url(#eyeGrad)"/>
      <!-- 瞳孔 -->
      <ellipse cx="0" cy="3" rx="5" ry="6" fill="#3c096c"/>
      <!-- 高光 -->
      <circle cx="-3" cy="-3" r="3.5" fill="#fff" opacity="0.9"/>
      <circle cx="3" cy="5" r="1.5" fill="#fff" opacity="0.7"/>
      <!-- 睫毛 -->
      <path d="M -14 -5 Q -8 -12 0 -12 Q 8 -12 14 -5" fill="none" stroke="#3c096c" stroke-width="2" stroke-linecap="round"/>
      <path d="M -16 -2 L -20 -8 M 16 -2 L 20 -8" stroke="#3c096c" stroke-width="1.5" stroke-linecap="round"/>
    </g>
    
    <!-- 眼睛（右眼） -->
    <g transform="translate(22, -5)">
      <ellipse cx="0" cy="0" rx="14" ry="16" fill="#fff"/>
      <ellipse cx="0" cy="2" rx="10" ry="12" fill="url(#eyeGrad)"/>
      <ellipse cx="0" cy="3" rx="5" ry="6" fill="#3c096c"/>
      <circle cx="-3" cy="-3" r="3.5" fill="#fff" opacity="0.9"/>
      <circle cx="3" cy="5" r="1.5" fill="#fff" opacity="0.7"/>
      <path d="M -14 -5 Q -8 -12 0 -12 Q 8 -12 14 -5" fill="none" stroke="#3c096c" stroke-width="2" stroke-linecap="round"/>
      <path d="M -16 -2 L -20 -8 M 16 -2 L 20 -8" stroke="#3c096c" stroke-width="1.5" stroke-linecap="round"/>
    </g>
    
    <!-- 眉毛 -->
    <path d="M -35 -22 Q -22 -28 -10 -22" fill="none" stroke="#c77dff" stroke-width="2" stroke-linecap="round"/>
    <path d="M 35 -22 Q 22 -28 10 -22" fill="none" stroke="#c77dff" stroke-width="2" stroke-linecap="round"/>
    
    <!-- 腮红 -->
    <ellipse cx="-35" cy="15" rx="10" ry="6" fill="url(#blushGrad)"/>
    <ellipse cx="35" cy="15" rx="10" ry="6" fill="url(#blushGrad)"/>
    
    <!-- 嘴巴 -->
    <path d="M -5 25 Q 0 30 5 25" fill="none" stroke="#ff8fab" stroke-width="2" stroke-linecap="round"/>
    
    <!-- 鼻子 -->
    <circle cx="0" cy="15" r="1" fill="#ffd6c2" opacity="0.8"/>
    
    <!-- 猫耳装饰（可选可爱元素） -->
    <path d="M -50 -55 Q -70 -90 -40 -85 Q -35 -75 -45 -60 Z" fill="url(#hairGrad)" opacity="0.8"/>
    <path d="M 50 -55 Q 70 -90 40 -85 Q 35 -75 45 -60 Z" fill="url(#hairGrad)" opacity="0.8"/>
    <path d="M -50 -55 Q -60 -75 -45 -70" fill="none" stroke="#ff8fab" stroke-width="1.5" opacity="0.6"/>
    <path d="M 50 -55 Q 60 -75 45 -70" fill="none" stroke="#ff8fab" stroke-width="1.5" opacity="0.6"/>
  </g>
  
  <!-- 前景装饰 -->
  <g opacity="0.3">
    <circle cx="100" cy="350" r="40" fill="#ffd6e0"/>
    <circle cx="700" cy="320" r="50" fill="#e0c3fc"/>
    <circle cx="200" cy="380" r="30" fill="#caffbf" opacity="0.5"/>
  </g>
  
  <!-- 标题文字 -->
  <text x="400" y="380" text-anchor="middle" font-family="Arial, sans-serif" font-size="18" fill="#ff6b9d" font-weight="bold" opacity="0.8">✨ 二次元视频下载工具 ✨</text>
</svg>

<br>

<img src="https://github.com/user-attachments/assets/9ba96833-9610-42b0-9dbf-95114fdc3be7" width="100" style="border-radius: 20px; margin: 10px 0; box-shadow: 0 4px 16px rgba(255,107,157,0.3);" alt="App Icon"/>

<br>

<!-- 动态徽章 -->
<img src="https://img.shields.io/github/stars/yxxawa/hanime1-downloader?style=for-the-badge&logo=github&color=ff6b9d&labelColor=2d3436&logoColor=white"/>
<img src="https://img.shields.io/github/forks/yxxawa/hanime1-downloader?style=for-the-badge&logo=github&color=a29bfe&labelColor=2d3436&logoColor=white"/>
<img src="https://img.shields.io/github/issues/yxxawa/hanime1-downloader?style=for-the-badge&logo=github&color=74b9ff&labelColor=2d3436&logoColor=white"/>
<img src="https://img.shields.io/github/license/yxxawa/hanime1-downloader?style=for-the-badge&logo=open-source-initiative&color=fecfef&labelColor=2d3436&logoColor=white"/>

<br><br>

<img src="https://img.shields.io/badge/Platform-Windows%20x64-ff6b9d?style=flat-square&logo=windows11&logoColor=white&labelColor=2d3436"/>
<img src="https://img.shields.io/badge/.NET-9.0-a29bfe?style=flat-square&logo=dotnet&logoColor=white&labelColor=2d3436"/>
<img src="https://img.shields.io/badge/UI-WPF-74b9ff?style=flat-square&logo=xaml&logoColor=white&labelColor=2d3436"/>
<img src="https://img.shields.io/badge/WebView2-Runtime-fecfef?style=flat-square&logo=microsoftedge&logoColor=white&labelColor=2d3436"/>

</div>

<br>

<!-- 社区交流 -->
<details open>
<summary><h2>📢 社区交流</h2></summary>
<div align="center">

> **💬 QQ 反馈 & 吹水群：`1102413927`**  
> 使用遇到问题、有功能建议、或者单纯想聊天，都欢迎来玩 ~

</div>
</details>

<br>

<!-- 界面预览 -->
<h2 align="center">📸 界面预览</h2>

<table align="center">
  <tr>
    <td align="center" width="33%">
      <img src="https://github.com/user-attachments/assets/f95681a9-dc23-4fb9-bb7b-ed99afc53b0b" width="100%" style="border-radius: 12px;"/>
      <br>
      <sub>🖥️ <b>主界面 · 浅色模式</b></sub>
    </td>
    <td align="center" width="33%">
      <img src="https://github.com/user-attachments/assets/31c3e4c3-ae8d-4ad7-88eb-68a645715251" width="100%" style="border-radius: 12px;"/>
      <br>
      <sub>🌙 <b>主界面 · 深色模式</b></sub>
    </td>
    <td align="center" width="33%">
      <img src="https://github.com/user-attachments/assets/a87d7e28-7fca-4c24-aef1-142fa0ce4022" width="100%" style="border-radius: 12px;"/>
      <br>
      <sub>🪶 <b>精简模式</b></sub>
    </td>
  </tr>
</table>

<br>

<!-- 功能特性 -->
<h2 align="center">✨ 功能特性</h2>

<details>
<summary><b>🔍 搜索与浏览</b> — 点击展开</summary>

<br>

| 功能 | 说明 |
|:---:|:---|
| 🔎 | **视频搜索** — 快速搜索 Hanime1 视频资源 |
| 🏷️ | **高级筛选** — 按标签、日期、热度等条件精准筛选 |
| 📋 | **详情查看** — 完整展示简介、标签列表、相关视频推荐 |

</details>

<details>
<summary><b>📥 下载与队列管理</b> — 点击展开</summary>

<br>

| 功能 | 说明 |
|:---:|:---|
| 🎬 | **多清晰度获取** — 自动解析不同画质的视频源 |
| 📥 | **下载队列** — 支持并发下载、暂停/恢复、失败自动重试 |
| 📝 | **历史记录** — 自动记录已下载任务，避免重复下载 |
| 🔄 | **失败重解析** — 下载失败后可手动触发重新解析视频源 |

</details>

<details>
<summary><b>⭐ 收藏与数据管理</b> — 点击展开</summary>

<br>

| 功能 | 说明 |
|:---:|:---|
| 💾 | **收藏夹** — 新建、重命名、删除、导入/导出收藏列表 |
| 📦 | **配置文件便携化** — 所有数据文件均保存在程序目录，方便迁移 |

</details>

<details>
<summary><b>🎨 个性化与体验</b> — 点击展开</summary>

<br>

| 功能 | 说明 |
|:---:|:---|
| 🌓 | **明暗主题** — 一键切换浅色 / 深色外观 |
| 🪶 | **精简模式** — 隐藏无关信息，界面更清爽 |
| 🧩 | **详情面板自定义** — 自由开关显示项，只看你关心的内容 |
| ▶️ | **内置播放器** — 无需切换软件，直接预览视频源 |
| 🌐 | **Cloudflare 会话复用** — 减少反复验证，提升使用流畅度 |
| 🖼️ | **封面与缩略图缓存** — 列表浏览更顺滑 |

</details>

<br>

<!-- 运行要求 -->
<h2 align="center">⚙️ 运行要求</h2>

<table align="center">
  <thead>
    <tr>
      <th align="center">🎯 环境</th>
      <th align="center">📋 要求</th>
    </tr>
  </thead>
  <tbody>
    <tr>
      <td align="center"><b>💻 开发运行</b></td>
      <td>Windows、<a href="https://dotnet.microsoft.com/download">.NET 9 SDK</a>、WebView2 Runtime</td>
    </tr>
    <tr>
      <td align="center"><b>🚀 发布版运行</b></td>
      <td>Windows x64、<a href="https://dotnet.microsoft.com/download/dotnet/9.0">.NET 9 Desktop Runtime</a>、WebView2 Runtime</td>
    </tr>
  </tbody>
</table>

> <div align="center">💡 <b>提示</b>：WebView2 Runtime 通常已预装在 Windows 11 中，若缺失可<a href="https://developer.microsoft.com/microsoft-edge/webview2/">点击此处下载</a>。</div>

<br>

<!-- 开发与构建 -->
<h2 align="center">🛠️ 开发与构建</h2>

```bash
# 构建项目
dotnet build "Hanime1Downloader.CSharp.csproj"

# 直接运行
dotnet run --project "Hanime1Downloader.CSharp.csproj"
```

<h3 align="center">📦 发布（单文件、非自包含、win-x64）</h3>

```bash
dotnet publish "Hanime1Downloader.CSharp.csproj" -c Release -p:DebugType=None -p:DebugSymbols=false
```

<div align="center">

发布输出路径：
<code>bin/Release/net9.0-windows/win-x64/publish/</code>

</div>

<br>

<!-- 数据与配置文件 -->
<h2 align="center">📁 数据与配置文件</h2>

<div align="center">

所有数据均存储在程序同目录下，**纯绿色便携**，拷贝文件夹即可完整迁移：

</div>

<br>

| 📄 文件 | 📝 说明 |
|:---|:---|
| `settings.json` | 程序主设置 |
| `favorites.json` | 收藏夹数据 |
| `download_history.json` | 下载历史记录 |
| `download_queue.json` | 下载队列（可设置是否保留） |
| `cookies.json` | Cloudflare 会话缓存 |
| `Downloads/` | 默认下载保存目录 |

<br>

<!-- 设置项 -->
<h2 align="center">🎛️ 设置项一览</h2>

<div align="center">

在设置窗口中你可以自定义以下选项：

</div>

<br>

<table align="center">
  <tr>
    <td align="center">🎬 <b>默认画质</b><br><sub>最高 / 高 / 中等 / 低</sub></td>
    <td align="center">🔄 <b>最大同时下载任务数</b><br><sub>自定义并发数量</sub></td>
  </tr>
  <tr>
    <td align="center">🌐 <b>站点域名管理</b><br><sub>支持自定义镜像站点</sub></td>
    <td align="center">💾 <b>关闭程序后是否保留下载队列</b><br><sub>持久化配置</sub></td>
  </tr>
  <tr>
    <td align="center">📂 <b>保存路径</b><br><sub>自定义下载目录</sub></td>
    <td align="center">📝 <b>文件命名规则</b><br><sub>自定义命名格式</sub></td>
  </tr>
  <tr>
    <td align="center">🌓 <b>明暗主题切换</b><br><sub>浅色 / 深色模式</sub></td>
    <td align="center">🖼️ <b>列表封面显示开关</b><br><sub>显示 / 隐藏缩略图</sub></td>
  </tr>
  <tr>
    <td align="center">🪶 <b>精简模式开关</b><br><sub>清爽界面模式</sub></td>
    <td align="center">🧩 <b>详情面板显示项自定义</b><br><sub>自由开关显示内容</sub></td>
  </tr>
</table>

<br>

<!-- 项目结构 -->
<h2 align="center">📂 项目结构速览</h2>

```
Hanime1Downloader.CSharp/
├── 📄 MainWindow.xaml(.cs)       # 主界面与核心交互逻辑
├── 📁 Views/                     # 子窗口：设置、筛选、WebView验证、播放器等
├── 📁 Services/                  # 业务服务：HTTP请求、下载器、主题管理、缩略图缓存等
├── 📁 Models/                    # 数据模型：设置、视频信息、下载项等
├── 📁 Assets/                    # 静态资源（如筛选项数据）
├── 📁 Themes/                    # 浅色 / 深色主题 XAML 资源
└── 📁 Converters/                # XAML 绑定值转换器
```

<br>

<!-- 许可证 -->
<h2 align="center">📄 许可证</h2>

<div align="center">

本项目遵循 <a href="https://github.com/yxxawa/hanime1DownLoader/blob/main/LICENSE"><b>MIT License</b></a> 开源协议

欢迎 Star ⭐、Fork 🍴 与 PR 🎉

</div>

<br>

<!-- 底部动态横幅 -->
<p align="center">
  <img src="https://capsule-render.vercel.app/api?type=waving&color=ff6b9d:a29bfe,100:74b9ff&height=120&section=footer&text=Made%20with%20%E2%9D%A4%EF%B8%8F%20by%20yxxawa&fontSize=20&fontColor=fff&animation=fadeIn" width="100%"/>
</p>

<div align="center">

**[⬆ 返回顶部](#hanime1-downloader)**

</div>
