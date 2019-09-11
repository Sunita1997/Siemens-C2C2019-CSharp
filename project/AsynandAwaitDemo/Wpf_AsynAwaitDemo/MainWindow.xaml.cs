using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Wpf_AsynAwaitDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CancellationTokenSource cancellationTokenSoure = new CancellationTokenSource();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CmdSync_Click(object sender, RoutedEventArgs e)
        {
            var watch = Stopwatch.StartNew();
            var results = DownloadTasks.RunDownloadSite();

            PrintWebSiteInfo(results, txtBlockSync);

            watch.Stop();
            var elapsedTime = watch.ElapsedMilliseconds;
            txtBlockSync.Text += $"Total Execution time {elapsedTime}{Environment.NewLine}";
        }

        private async void CmdAsync_Click(object sender, RoutedEventArgs e)
        {
            Progress<ProgressDataModel> progress = new Progress<ProgressDataModel>();
            progress.ProgressChanged += ReportProgress;

            var watch = Stopwatch.StartNew();
            try
            {
                //cancellationTokenSoure.IsCancellationRequested
                var results = await DownloadTasks.RunDownloadSiteAsync(progress, cancellationTokenSoure.Token);
            }
            catch (OperationCanceledException)
            {
                txtBlockAsync.Text += $"async download operation cancelled{Environment.NewLine}";
            }
            //PrintWebSiteInfo(results, txtBlockAsync);
            watch.Stop();
            var elapsedTime = watch.ElapsedMilliseconds;
            txtBlockAsync.Text += $"Total Execution time {elapsedTime}{Environment.NewLine}";
        }

        private void ReportProgress(object sender, ProgressDataModel e)
        {
            progressReportBar.Value = e.PercentageCompleted;
            PrintWebSiteInfo(e.WebsitesDownloaded, txtBlockAsync);
            if (progressReportBar.Value == 100)
                progressReportBar.Visibility = Visibility.Hidden;
        }

        private async void CmdParallelAsync_Click(object sender, RoutedEventArgs e)
        {
            var watch = Stopwatch.StartNew();
            var results = await DownloadTasks.RunDownloadSiteParallelAsync();
            PrintWebSiteInfo(results, txtBlockParallelAsync);
            watch.Stop();
            var elapsedTime = watch.ElapsedMilliseconds;
            txtBlockParallelAsync.Text += $"Total Execution time {elapsedTime}{Environment.NewLine}";
        }
        private void PrintWebSiteInfo(List<WebSiteDataModel> list, TextBlock txtBlock)
        {
            txtBlock.Text = "";
            list.ForEach(data =>
            txtBlock.Text += $"{data.WebSiteUrl} downloaded: {data.WebSiteData.Length} caharacters long {Environment.NewLine}");
        }

        private void CmdAsyncCancel_Click(object sender, RoutedEventArgs e)
        {
            cancellationTokenSoure.Cancel();
        }
    }
}
