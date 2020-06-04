using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Gallery.Pages {
    public class IndexModel : PageModel {
        public IndexModel(IWebHostEnvironment env) {
            this.env = env;
        }

        private readonly IWebHostEnvironment env;

        public IFormFile UploadedFile { get; set; }

        public List<FileInfo> FileList = new List<FileInfo>();
        public List<string> imagetypes = new List<string> { ".jpg", ".png" };
        public bool isImage(FileInfo file) {
            return imagetypes.Contains(file.Extension);
        }

        public void OnPost(string uploader) {
            string copyPath = Path.Combine(env.ContentRootPath, "wwwroot",
                "uploads", UploadedFile.FileName);
            UploadedFile.CopyTo(new FileStream(copyPath,
               FileMode.OpenOrCreate));
        }
    }
}
