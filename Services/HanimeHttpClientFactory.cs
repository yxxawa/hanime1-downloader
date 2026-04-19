using System.Net;
using System.Net.Http;
using Hanime1Downloader.CSharp.Models;

namespace Hanime1Downloader.CSharp.Services;

public sealed class HanimeHttpClientFactory
{
    public HttpClient Create(IReadOnlyList<BrowserCookieRecord> cookies, string siteHost = "hanime1.me", string? browserVersion = null)
    {
        var bridge = new CookieSessionBridge(siteHost);
        var handler = new HttpClientHandler
        {
            CookieContainer = bridge.CreateCookieContainer(cookies),
            AutomaticDecompression = DecompressionMethods.All
        };

        var baseUrl = $"https://{siteHost}/";
        var client = new HttpClient(handler)
        {
            BaseAddress = new Uri(baseUrl),
            Timeout = Timeout.InfiniteTimeSpan
        };

        var userAgent = BrowserIdentity.BuildUserAgent(browserVersion);
        client.DefaultRequestHeaders.TryAddWithoutValidation("User-Agent", userAgent);
        client.DefaultRequestHeaders.TryAddWithoutValidation("Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/avif,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.7");
        client.DefaultRequestHeaders.TryAddWithoutValidation("Accept-Language", "zh-CN,zh;q=0.9,en-US;q=0.8,en;q=0.7");
        client.DefaultRequestHeaders.TryAddWithoutValidation("Accept-Encoding", "gzip, deflate, br");
        client.DefaultRequestHeaders.TryAddWithoutValidation("Cache-Control", "max-age=0");
        client.DefaultRequestHeaders.Connection.Clear();
        client.DefaultRequestHeaders.Connection.Add("keep-alive");
        client.DefaultRequestHeaders.TryAddWithoutValidation("Referer", baseUrl);
        client.DefaultRequestHeaders.TryAddWithoutValidation("Sec-Ch-Ua", BrowserIdentity.BuildSecChUa(browserVersion));
        client.DefaultRequestHeaders.TryAddWithoutValidation("Sec-Ch-Ua-Mobile", "?0");
        client.DefaultRequestHeaders.TryAddWithoutValidation("Sec-Ch-Ua-Platform", "\"Windows\"");
        client.DefaultRequestHeaders.TryAddWithoutValidation("Sec-Fetch-Dest", "document");
        client.DefaultRequestHeaders.TryAddWithoutValidation("Sec-Fetch-Mode", "navigate");
        client.DefaultRequestHeaders.TryAddWithoutValidation("Sec-Fetch-Site", "same-origin");
        client.DefaultRequestHeaders.TryAddWithoutValidation("Sec-Fetch-User", "?1");
        client.DefaultRequestHeaders.TryAddWithoutValidation("Upgrade-Insecure-Requests", "1");
        return client;
    }
}
