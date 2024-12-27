using Microsoft.AspNetCore.Mvc;
using SEA_ApiTest.Models;
using System.Diagnostics;

namespace SEA_ApiTest.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return Redirect("~/show/log");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [Route("show/Log")]
        public IActionResult Log()
        {
            return View();
        }

        [HttpGet]
        [Route("home/LogFileName")]
        public object LogFileName()
        {
            var dirPath = $"{Environment.CurrentDirectory}\\{Utils.Log.Dir}";
            //Utils.Log.print($"_Log dir path->{dirPath}");
            var dirInfo = new DirectoryInfo(dirPath);

            var names = (from file in dirInfo.GetFiles()
                         select file.Name).ToList();

            //names.Foreach(name =>
            //{
            //    Utils.Log.print($"_Log file name->{name}");
            //});


            return names;
        }

        [HttpGet]
        public async Task<IActionResult> LoadFile(string name)
        {
            var path = $"{Environment.CurrentDirectory}\\{Utils.Log.Dir}\\{name}";
            //Utils.Log.print($"LoadFile path->{path}");
            var memory = new MemoryStream();
            using (var stream = new FileStream(path, FileMode.Open))
            {
                await stream.CopyToAsync(memory);
            }
            memory.Position = 0;
            var ext = Path.GetExtension(path).ToLowerInvariant();
            return File(memory, GetMimeTypes()[ext], Path.GetFileName(path));
        }

        private Dictionary<string, string> GetMimeTypes()
        {
            return new Dictionary<string, string>
            {
                {".txt", "text/plain"},
                {".pdf", "application/pdf"},
                {".doc", "application/vnd.ms-word"},
                {".docx", "application/vnd.ms-word"},
                {".png", "image/png"},
                {".jpg", "image/jpeg"}
            };
        }
    }
}