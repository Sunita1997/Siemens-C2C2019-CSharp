using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_AsynAwaitDemo
{
    public class ProgressDataModel
    {
        public int PercentageCompleted { get; set; } = 0;
        public List<WebSiteDataModel> WebsitesDownloaded { get; set; } = new List<WebSiteDataModel>();
    }
}
