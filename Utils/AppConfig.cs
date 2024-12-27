namespace SEA_ApiTest.Utils
{
    public static class AppConfig
    {
        public static string ApiKey = ConfigUtil.Start().Get("ApiKey");
        public static int TestAgentID = ConfigUtil.Start().Get("TestAgentID").toInt();
        public static string Manufacturer = ConfigUtil.Start().Get("Manufacturer");
        public static string rouletteConfig = ConfigUtil.Start().Get("rouletteConfig");
        public static string ProjectVer = ConfigUtil.Start().Get("ProjectVersion");
        public static string PhysDic = ConfigUtil.Start().Get("PhysDic");
        public static string VirtualDic = ConfigUtil.Start().Get("VirtualDic");

        public const string ApiCacheFileName = "ApiCacheConfig";
    }
}
