using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Wpf_AsynAwaitDemo
{
    public static class DownloadTasks
    {
        private static List<string> GetPrepData()
        {
            List<string> websites = new List<string>
            {
                "https://www.google.co.in",
                "https://www.microsoft.com",
                "https://www.stackoverflow.com",
                "https://www.cnn.com",
                "https://www.codeproject.com"
            };
            return websites;
        }

        #region synchronous operations
        public static List<WebSiteDataModel> RunDownloadSite()
        {
            var list = GetPrepData();
            List<WebSiteDataModel> results = new List<WebSiteDataModel>();
            foreach (string site in list)
            {
                results.Add(Download(site));
            }
            return results;
        }
        private static WebSiteDataModel Download(string url)
        {
            WebSiteDataModel webSite = null;
            using (var client = new WebClient())
            {
                webSite = new WebSiteDataModel();
                webSite.WebSiteUrl = url;
                webSite.WebSiteData = client.DownloadString(url);
            }
            return webSite;
        }
        #endregion

        #region asynchronous operations
        public async static Task<List<WebSiteDataModel>> RunDownloadSiteAsync(IProgress<ProgressDataModel> progress, CancellationToken cancellationToken)
        {
            var list = GetPrepData();
            List<WebSiteDataModel> results = new List<WebSiteDataModel>();
            ProgressDataModel report = new ProgressDataModel();
            foreach (string site in list)
            {
                var siteInfo = await DownloadAsync(site);
                results.Add(siteInfo);
                cancellationToken.ThrowIfCancellationRequested();
                report.WebsitesDownloaded = results;
                report.PercentageCompleted = (results.Count * 100) / list.Count;
                progress.Report(report);
            }
            return results;
        }
        private static async Task<WebSiteDataModel> DownloadAsync(string url)
        {
            WebSiteDataModel webSite = null;
            using (var client = new WebClient())
            {
                webSite = new WebSiteDataModel();
                webSite.WebSiteUrl = url;
                webSite.WebSiteData = await Task.Run(() => client.DownloadString(url));
            }
            return webSite;
        }
        #endregion

        #region parallel asynchronous operations
        public async static Task<List<WebSiteDataModel>> RunDownloadSiteParallelAsync()
        {
            var list = GetPrepData();
            List<Task<WebSiteDataModel>> taskList = new List<Task<WebSiteDataModel>>();
            foreach (string site in list)
            {
                taskList.Add(DownloadParallelAsync(site));
            }

            var results = await Task.WhenAll(taskList);
            return results.ToList<WebSiteDataModel>();
        }
        private static async Task<WebSiteDataModel> DownloadParallelAsync(string url)
        {
            WebSiteDataModel webSite = null;
            using (var client = new WebClient())
            {
                webSite = new WebSiteDataModel();
                webSite.WebSiteUrl = url;
                webSite.WebSiteData = await client.DownloadStringTaskAsync(url);
            }
            return webSite;
        }
        #endregion
    }
}
