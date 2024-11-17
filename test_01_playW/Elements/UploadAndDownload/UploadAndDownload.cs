using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_01_playW
{
    internal class UploadAndDownload
    {
        private readonly ILocator download;
        public UploadAndDownload(IPage page) 
        {
            download = page.GetByText("Upload and Download");
        }

        public async Task UaD_click()
        {
            download.ClickAsync();
        }
    }
}
