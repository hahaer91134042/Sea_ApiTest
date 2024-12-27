using Microsoft.AspNetCore.Builder;

namespace SEA_ApiTest.Utils
{
    public static class WebEnvironment
    {
        private static IWebHostEnvironment _hostEnvironment;
        public static string WebPath = "";

        public static string MapPath(string path="")
        {
            if (path == "~/" || path == "")
                return _hostEnvironment.WebRootPath;
            return Path.Combine(_hostEnvironment.WebRootPath, path);
        }

        internal static void Configure(IWebHostEnvironment env)
        {
            _hostEnvironment= env;
            WebPath = _hostEnvironment.WebRootPath;
        }
    }

    public static class WebEnvironmentExtensions
    {
        public static IApplicationBuilder UseStaticHostEnviroment(this IApplicationBuilder app)
        {
            var env = app.ApplicationServices.GetRequiredService<IWebHostEnvironment>();
            WebEnvironment.Configure(env);
            return app;
        }
    }
}
