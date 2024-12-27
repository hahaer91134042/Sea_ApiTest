namespace SEA_ApiTest.Models.Attribute
{
    [AttributeUsage(AttributeTargets.Class)]
    public class DbContextConfigAttr: System.Attribute
    {
        public string sqlPath;
        public string verPath;
        public DbContextConfigAttr(string sql,string ver) 
        { 
            sqlPath= sql;
            verPath= ver;
        }
    }
}
