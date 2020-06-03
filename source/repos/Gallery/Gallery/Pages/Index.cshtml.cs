using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
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

        public void OnPost(string uploader) {
            string copyPath = Path.Combine(env.ContentRootPath, "wwwroot",
                "uploads", UploadedFile.FileName);
            UploadedFile.CopyTo(new FileStream(copyPath,
               FileMode.OpenOrCreate));
        }
    }
}
