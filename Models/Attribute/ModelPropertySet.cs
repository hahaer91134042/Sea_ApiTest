namespace SEA_ApiTest.Models.Attribute
{
    [AttributeUsage(AttributeTargets.Property)]
    public class ModelPropertySet: System.Attribute
    {
        public string Key;
        public ModelPropertySet(string k)=>Key = k;
    }
}
