using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Org.BouncyCastle.Asn1.Ocsp;
using SEA_ApiTest.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SEA_ApiTest
{
    /// <summary>
    /// 一些常用的擴展函式包
    /// </summary>
    public static class ExtLibs
    {
        // Kotlin: fun <T, R> T.let(block: (T) -> R): R
        public static R Let<T, R>(this T self, Func<T, R> block)
        {
            return block(self);
        }

        // Kotlin: fun <T> T.also(block: (T) -> Unit): T
        public static T Also<T>(this T self, Action<T> block)
        {
            block(self);
            return self;
        }

        #region object property extension
        public static bool isNullOrEmpty(this object? obj)
        {
            if (obj == null) return true;
            return obj is string ? string.IsNullOrEmpty(obj.ToString()) : obj == null;
        }

        public static IEnumerable<PropertyInfo> getAttrProperty<T>(this object obj) where T : Attribute
        {
            return (from p in obj.GetType().GetProperties()
                    where p.isDefinedAttr<T>()
                    select p);
        }
        public static bool isDefinedAttr<T>(this PropertyInfo info) where T : Attribute
        {
            return info.IsDefined(typeof(T), true);
        }
        public static T? getAttribute<T>(this Type t, bool inherit = true) where T : Attribute
        {
            return t.GetCustomAttribute<T>(inherit);
        }
        public static T? getAttribute<T>(this PropertyInfo info, bool inherit = true) where T : Attribute
        {
            return (T?)info.GetCustomAttributes(typeof(T), inherit).FirstOrDefault();
        }
        public static void setObjValue(this object input, string name, object? value)
        {
            var type = input.GetType();
            if (type.GetProperty(name) != null)
                type.GetProperty(name)!.SetValue(input, value);
        }
        public static T? getObjValue<T>(this object obj, string propertyName)
        {
            return (T?)obj.GetType().GetProperty(propertyName)?.GetValue(obj, null);
        }
        public static Dictionary<string,T?> getObjValue<T>(this object from ,params string[] propertyNames)
        {
            var t = from.GetType();
            var result=new Dictionary<string,T?>();

            (from k in propertyNames
             join p in t.GetProperties() on k equals p.Name
             select p).Foreach(p =>
             {
                 result.Add(p.Name, (T?)p.GetValue(from, null));
             });

            return result;
        }
        #endregion

        #region Number Extension
        public static int toInt(this object obj) => Convert.ToInt32(obj);
        public static double toDouble(this object input) => Convert.ToDouble(input);
        public static decimal toDecimal(this object input) => Convert.ToDecimal(input);
        public static long toLong(this object input) => Convert.ToInt64(input);
        public static float toFloat(this object input) => Convert.ToSingle(input);
        public static bool isNumber(this object o, bool bigInt = false)
        {
            if (o == null)
                return false;

            if (o.ToString().Trim().Length == 0)
                return false;

            if (bigInt)
            {
                long l;
                return long.TryParse(o.ToString(), out l);
            }
            else
            {
                int i;
                return int.TryParse(o.ToString(), out i);
            }

        }
        #endregion

        #region String Extension
        public static string toUTF8(this string input) => new UTF8Encoding().GetString(Encoding.UTF8.GetBytes(input));
        public static sbyte toSbyte(this object input) => Convert.ToSByte(input);
        #endregion

        #region DateTime Extension
        /// <summary>
        /// DateTime使用預設的字串格式
        /// </summary>
        /// <param name="time"></param>
        /// <param name="format"></param>
        /// <returns></returns>
        public static string toString(this DateTime time, string format = TimeUtils.DateTimeFormat) => time.ToString(format);
        
        public static DateTime toDateTime(this string input,string format = TimeUtils.DateTimeFormat)
        {
            try
            {
                DateTime t = DateTime.MinValue;
                DateTime.TryParseExact(input?.Trim()??"", format, null, System.Globalization.DateTimeStyles.None, out t);
                return t;
            }
            catch(Exception e)
            {
                Log.d($"DateTime Parse Error->{e}");
            }
            return DateTime.MinValue;
        }

        #endregion

        #region Json Convert
        public static string toJsonString(this object obj)
        {
            return JsonConvert.SerializeObject(obj);
        }
        public static T? toObj<T>(this object input)
        {
            try
            {
                //目前先這樣 之後有機會再改看看
                return JsonConvert.DeserializeObject<T>(input.toJsonString());
            }
            catch (Exception) { }
            return default;
        }
        public static T? toObj<T>(this string input)
        {
            try
            {
                return JsonConvert.DeserializeObject<T>(input);
            }
            catch (Exception) { }
            return default;
        }
        public static dynamic jsonDynamic(this string input) => input.toObj<dynamic>()??new { };
        #endregion

        #region IEenumable
        public static void Foreach<T>(this IEnumerable<T> input, Action<T> back)
        {
            foreach (var item in input) { back(item); }
        }
        #endregion

        #region Type extension

        /// <summary>
        /// 檢查物件是有繼承Interface
        /// </summary>
        /// <typeparam name="I">Interface Type</typeparam>
        /// <param name="child">Implement object</param>
        /// <returns></returns>
        public static bool hasInterface<I>(this object child)
        {
            return typeof(I).IsAssignableFrom(child.GetType());
        }
        #endregion

        #region Enum extension
        public static E toEnum<E>(this string input, bool ignoreCase = false) where E : struct,System.Enum
        {
            return (E)System.Enum.Parse(typeof(E), input, ignoreCase);
        }

        public static E toEnum<E>(this int input) where E : struct,System.Enum
        {
            return (E)System.Enum.ToObject(typeof(E), input);
        }
        public static bool isDefineEnum<E>(this int input) where E : struct,System.Enum => System.Enum.IsDefined(typeof(E), input);

        public static string getDescription(this System.Enum value)
        {
            FieldInfo? fi = value.GetType().GetField(value.ToString());
            DescriptionAttribute[] attributes = (DescriptionAttribute[])fi?.GetCustomAttributes(typeof(DescriptionAttribute), false)!;
            return attributes.Length > 0 ? attributes[0].Description : value.ToString();
        }
        public static T toEnumByDescript<T>(this string input)where T : struct, System.Enum
        {
            var value = (from i in typeof(T).GetFields()
                         where i.GetCustomAttribute<DescriptionAttribute>() != null
                         where i.GetCustomAttribute<DescriptionAttribute>()!.Description == input
                         select i.GetRawConstantValue()).FirstOrDefault();
            if (value == null)
                throw new NullReferenceException("Enum Description Value Not Match!");

            return (T)System.Enum.ToObject(typeof(T),value);
        }
        #endregion

        #region DbSet

        /// <summary>
        /// 可以允許空值得where
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="set"></param>
        /// <param name="back"></param>
        /// <returns></returns>
        public static IQueryable<T> where<T>(this IQueryable<T> set,Expression<Func<T,bool>>? back=null)where T : class
        {
            if(back==null)
                return set;
            return set.Where(back);
        }
        #endregion

        #region HttpRequest
        public static Dictionary<string,string> QueryVal(this Uri uri)
        {
            var dic = new Dictionary<string, string>();
            try
            {
                var queryStr = uri.Query.Substring(1);
                Log.print($"uri query ->{queryStr}");

                queryStr.Split('&').Foreach(frag =>
                {
                    var sub = frag.Split('=');
                    dic[sub[0]] = sub[1].Trim();
                });
            }
            catch (Exception ex)
            {
                Log.print($"Uri QueryVal error->{ex}");
            }
            return dic;
        }
        public static Uri GetRawUrl(this HttpRequest request)
        {
            //var httpContext = request.HttpContext;
            //Microsoft.AspNetCore.Http.Extensions.UriHelper.GetFullUrl(request);
            //var requestFeature = httpContext.Features.Get<IHttpRequestFeature>();
            //Log.print($"PathAndQuery->{UriHelper.GetEncodedPathAndQuery(request)}  DisplayUrl->{UriHelper.GetDisplayUrl(request)}");
            return new Uri(UriHelper.GetDisplayUrl(request));
        }
        public static string GetAbsoluteUri(this HttpRequest req)
        {
            return $"{req.Scheme}://{req.Host}{req.PathBase}{req.Path}{req.QueryString}";
        }
        /// <summary>
        /// 获取http请求方式为application/json 的参数
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public static string GetBodyString(this HttpRequest req)
        {
            var bodyStr = "";
            req.Body.Position = 0;
            using (StreamReader reader
                      = new StreamReader(req.Body, Encoding.UTF8, true, 1024, true))
            {
                bodyStr = reader.ReadToEnd();
            }            
            return bodyStr;
        }
        #endregion
    }
}

