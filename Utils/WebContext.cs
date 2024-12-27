

namespace SEA_ApiTest
{
    public class WebContext
    {

        public static HttpContext? Current;

        private WebContext()
        {
        }

        public static void Refresh(IHttpContextAccessor a)
        {
            Current = a.HttpContext;

        }

        public static string GetIp()
        {
            if (Current?.Request.Headers.ContainsKey("X-Forwarded-For") ?? false)
                return Current.Request.Headers["X-Forwarded-For"];

            var ip = Current?.Connection.RemoteIpAddress?.MapToIPv4().ToString() ?? "127.0.0.1";

            return ip == "0.0.0.1" ? "127.0.0.1" : ip;
        }
    }
}
