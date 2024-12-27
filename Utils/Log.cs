

namespace SEA_ApiTest.Utils
{
    public class Log
    {
        private static ILogger? _log;

        private const string LogFileName = "ApiLog";
        public const string Dir = "_Log";

        public static void start(IServiceProvider provider)
        {
            _log = provider.GetService<ILogger<Log>>();
        }

        public static void print(string msg)
        {
            txtWriter(LogFileName, $"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}  {msg}");
        }
        public static void printError(Exception e,string flag="")
        {
            txtWriter(LogFileName, $"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")} {flag} Error-> {e}");
        }

        #region 写入文本日志
        static object logLockObj = new object();
        private static void txtWriter(string file_name, string str)
        {
            try
            {
                //写锁
                //logLockObj.EnterWriteLock();
                lock (logLockObj)
                {
                    string dir = AppDomain.CurrentDomain.BaseDirectory + $"/{Dir}/";
                    if (!Directory.Exists(dir))
                    {
                        Directory.CreateDirectory(dir);
                    }
                    using (FileStream stream = new FileStream(dir + file_name + DateTime.Now.ToString("yyyy-MM-dd") + ".txt", FileMode.Append))
                    using (StreamWriter writer = new StreamWriter(stream))
                    {
                        writer.WriteLine(str);
                    }
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                //释放
                //logLockObj.ExitWriteLock();
                //logLockObj.Dispose();
            }
        }
        #endregion
        public static void d(string msg)
        {
            _log?.LogWarning(msg);
        }
        public static void e(Exception e)
        {
            _log?.LogError($"GetError->{e}");
        }
        public static void e(string flag,Exception e)
        {
            _log?.LogError($"{flag} GetError->{e}");
        }
    }
}
