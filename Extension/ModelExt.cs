using SEA_ApiTest.Models.Attribute;
using SEA_ApiTest.Models.Impl;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Reflection;

namespace SEA_ApiTest.Extension
{
    public static class ModelExt
    {        

        /// <summary>
        /// 資料轉換使用
        /// 可配合ModelPropertySet
        /// 需注意型態
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="from"></param>
        /// <returns></returns>
        public static T copyTo<T>(this object from)where T :new()
        {
            var fromAttrs = new Dictionary<string, PropertyInfo>();
            foreach ( var p in from.GetType().GetProperties())
            {
                //預設先檢查有無設置好的property Key 沒有就直接用名稱的
                fromAttrs.Add(p.getAttribute<ModelPropertySet>()?.Key??p.Name, p);
            }

            var target=new T();

            foreach(var prop in target.GetType().GetProperties())
            {
                var targetPName = prop.getAttribute<ModelPropertySet>()?.Key ?? prop.Name;
                var fromProp = (from p in fromAttrs
                                where p.Key== targetPName
                                select p.Value).FirstOrDefault();              

                if (fromProp == null)
                    continue;

                prop.SetValue(target, fromProp.GetValue(from, null)); 
            }

            return target;
        }
    }
}
