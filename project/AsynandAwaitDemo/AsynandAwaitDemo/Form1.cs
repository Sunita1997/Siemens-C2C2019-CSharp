using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsynandAwaitDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdSync_Click(object sender, EventArgs e)
        {
            var watch = Stopwatch.StartNew();
            var results = DownloadTasks.RunDownloadSite();
            PrintWebSiteInfo(results, richTextBox1);
            watch.Stop();
            var elapsedTime = watch.ElapsedMilliseconds;
            richTextBox1.Text += $"Total Execution time {elapsedTime}{Environment.NewLine}";
        }

        private async void cmdAsync_Click(object sender, EventArgs e)
        {
           
            var watch = Stopwatch.StartNew();
            var results = await DownloadTasks.RunDownloadSiteAsync();
            PrintWebSiteInfo(results,richTextBox2);
            watch.Stop();
            var elapsedTime = watch.ElapsedMilliseconds;
            richTextBox2.Text += $"Total Execution time {elapsedTime}{Environment.NewLine}";
        }


        private async void cmdParallelAsync_Click(object sender, EventArgs e)
        {
            var watch = Stopwatch.StartNew();
            var results = await DownloadTasks.RunDownloadSiteParallelAsync();
            PrintWebSiteInfo(results, richTextBox3);
            watch.Stop();
            var elapsedTime = watch.ElapsedMilliseconds;
            richTextBox3.Text += $"Total Execution time {elapsedTime}{Environment.NewLine}";
        }
        private void PrintWebSiteInfo(List<WebSiteDataModel> list, RichTextBox richTextBox)
        {
            richTextBox.Text = "";
            list.ForEach(data =>
            richTextBox.Text += $"{data.WebSiteUrl} downloaded: {data.WebSiteData.Length} caharacters long {Environment.NewLine}");
        }
    }
}
