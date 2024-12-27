using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security.Cryptography;
using System.Net;
using System.IO;
using System.Text;
using Newtonsoft.Json;
using System.Text.RegularExpressions;
using SEA_ApiTest.Models.Impl;
using SEA_ApiTest.Models;
using SEA_ApiTest.DAO;
using SEA_ApiTest.Models.ManageDb;
using Newtonsoft.Json.Linq;
using System.Runtime.InteropServices;

using System.Net.Mail;


namespace SEA_ApiTest.Utils
{
    public class Util
    {
        #region MD5加密
        public static string MD5hash(string pwd)
        {
            var md5 = MD5.Create();
            byte[] data = System.Text.Encoding.Default.GetBytes(pwd);
            byte[] md5data = md5.ComputeHash(data);
            md5.Clear();
            string str = "";
            for (int i = 0; i < md5data.Length; i++)
            {
                str += md5data[i].ToString("x").PadLeft(2, '0');

            }
            return str;
        }
        #endregion
        #region 生成随机字母或数字
        /// <summary>
        /// 生成随机数字
        /// </summary>
        /// <param name="length">生成长度</param>
        /// <returns></returns>
        public static string Number(int Length)
        {
            return Number(Length, false);
        }

        /// <summary>
        /// 生成随机数字
        /// </summary>
        /// <param name="Length">生成长度</param>
        /// <param name="Sleep">是否要在生成前将当前线程阻止以避免重复</param>
        /// <returns></returns>
        public static string Number(int Length, bool Sleep)
        {
            if (Sleep)
                System.Threading.Thread.Sleep(3);
            string result = "";
            System.Random random = new Random();
            for (int i = 0; i < Length; i++)
            {
                result += random.Next(10).ToString();
            }
            return result;
        }
        /// <summary>
        /// 生成随机字母字符串(数字字母混和)
        /// </summary>
        /// <param name="codeCount">待生成的位数</param>
        public static string GetCheckCode(int codeCount)
        {
            string str = string.Empty;
            int rep = 0;
            long num2 = DateTime.Now.Ticks + rep;
            rep++;
            Random random = new Random(((int)(((ulong)num2) & 0xffffffffL)) | ((int)(num2 >> rep)));
            for (int i = 0; i < codeCount; i++)
            {
                char ch;
                int num = random.Next();
                if ((num % 2) == 0)
                {
                    ch = (char)(0x30 + ((ushort)(num % 10)));
                }
                else
                {
                    ch = (char)(0x41 + ((ushort)(num % 0x1a)));
                }
                str = str + ch.ToString();
            }
            return str;
        }
        /// <summary>
        /// 随机生成大小写数字字符串
        /// </summary>
        /// <returns></returns>
        public static string CreateCheckCode(int n)
        {
            char[] CharArray = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            string sCode = "";

            Random random = new Random(Guid.NewGuid().GetHashCode());
            for (int i = 0; i < n; i++)
            {
                sCode += CharArray[random.Next(CharArray.Length)];
            }

            return sCode;
        }

        /// <summary>
        /// 根据日期和随机码生成订单号
        /// </summary>
        /// <returns></returns>
        public static string GetOrderNumber()
        {
            string num = GetUnix().ToString();//yyyyMMddHHmmssms
            return $"O{num}{Number(5)}";// num + Number(2).ToString();
        }
    //public static string GetOrderNumber()
    //{
    //    string num = DateTime.Now.ToString("yyMMddHHmmss");//yyyyMMddHHmmssms
    //    return num + Number(2).ToString();
    //}
    private static int Next(int numSeeds, int length)
        {
            byte[] buffer = new byte[length];
            System.Security.Cryptography.RNGCryptoServiceProvider Gen = new System.Security.Cryptography.RNGCryptoServiceProvider();
            Gen.GetBytes(buffer);
            uint randomResult = 0x0;//这里用uint作为生成的随机数  
            for (int i = 0; i < length; i++)
            {
                randomResult |= ((uint)buffer[i] << ((length - 1 - i) * 8));
            }
            return (int)(randomResult % numSeeds);
        }
        #endregion

        #region URL请求数据
        public static string HttpGet(string url)
        {
            return HttpGet(url, Encoding.UTF8);
        }

        /// <summary>
        /// HTTP GET方式请求数据.
        /// </summary>
        /// <param name="url">URL.</param>
        /// <returns></returns>
        public static string HttpGet(string url, Encoding encoding, int timeOut = 15000)
        {
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(url);
            request.Method = "GET";
            //request.ContentType = "application/x-www-form-urlencoded";
            request.Accept = "*/*";
            if (timeOut > 0)
                request.Timeout = timeOut;
            request.AllowAutoRedirect = false;

            WebResponse response = null;
            string responseStr = null;

            try
            {
                response = request.GetResponse();

                if (response != null)
                {
                    StreamReader reader = new StreamReader(response.GetResponseStream(), encoding);
                    responseStr = reader.ReadToEnd();
                    reader.Close();
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                request = null;
                response = null;
            }

            return responseStr;
        }
        public static string HttpPost(string url, string param)
        {
            //Log.print($"HttpPost url->{url} param->{param}");
            var responseStr = "";
            try
            {
                HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(url);
                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";
                request.Accept = "*/*";
                request.Timeout = 15000;
                request.AllowAutoRedirect = false;

                var requestStream = new StreamWriter(request.GetRequestStream());
                
                requestStream.Write(param);
                requestStream.Close();

                var response = request.GetResponse();
                if (response != null)
                {
                    StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
                    responseStr = reader.ReadToEnd();
                    reader.Close();
                }
            }
            catch (Exception e)
            {
                throw;
            }
            //Log.print($"HttpPost result->{responseStr}");
            return responseStr;
        }
        public static string HttpPost(string url, string param,string contentType)
        {
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(url);
            request.Method = "POST";
            if (string.IsNullOrEmpty(contentType))
            {
                request.ContentType = "application/x-www-form-urlencoded";
            }
            else { request.ContentType = contentType; }
            request.Accept = "*/*";
            request.Timeout = 15000;
            request.AllowAutoRedirect = false;

            StreamWriter requestStream = null;
            WebResponse response = null;
            string responseStr = null;

            try
            {
                requestStream = new StreamWriter(request.GetRequestStream());
                requestStream.Write(param);
                requestStream.Close();

                response = request.GetResponse();
                if (response != null)
                {
                    StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
                    responseStr = reader.ReadToEnd();
                    reader.Close();
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                request = null;
                requestStream = null;
                response = null;
            }

            return responseStr;
        }

        public static string HttpPost(string url, string param, bool isBackError, string contentType = null)
        {
            HttpWebRequest request = null;
            StreamWriter requestStream = null;
            WebResponse response = null;
            string responseStr = null;
            try
            {
                request = (HttpWebRequest)HttpWebRequest.Create(url);
                request.Method = "POST";
                if (contentType == null) { contentType = "application/x-www-form-urlencoded"; }
                request.ContentType = contentType;
                request.Accept = "*/*";
                //request.Timeout = 15000;
                request.AllowAutoRedirect = false;
                requestStream = new StreamWriter(request.GetRequestStream());
                requestStream.Write(param);
                requestStream.Close();

                response = request.GetResponse();
                if (response != null)
                {
                    StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
                    responseStr = reader.ReadToEnd();
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                if (isBackError)
                {
                    int status = -1;
                    if (ex.Message.IndexOf("404") > -1 || ex.Message.IndexOf("无效的URL") > -1) { status = -2; }
                    else if (ex.Message.IndexOf("超时") > -1) { status = -3; }
                    else { status = -4; }
                    string backStr = "{\"status\":" + status + ",\"msg\":\"" + ex.Message + "\"}";
                    return backStr;
                }
                else
                {
                    throw;
                }
            }
            finally
            {
                request = null;
                requestStream = null;
                response = null;
            }

            return responseStr;
        }

        #endregion

        #region 检查是否为IP地址
        /// <summary>
        /// 是否为ip
        /// </summary>
        /// <param name="ip"></param>
        /// <returns></returns>
        public static bool IsIP(string ip)
        {
            return Regex.IsMatch(ip, @"^((2[0-4]\d|25[0-5]|[01]?\d\d?)\.){3}(2[0-4]\d|25[0-5]|[01]?\d\d?)$");
        }
        #endregion

        #region 时间戳转换
        public static DateTime TimeToUnix(long timeStamp)
        {
            DateTime dtStart = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1));
            long lTime = long.Parse(timeStamp + "0000000");
            TimeSpan toNow = new TimeSpan(lTime);
            return dtStart.Add(toNow);
        }
        public static long GetUnix()
        {
            long res = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000) / 10000000;
            return res;
        }
        public static long GetUnix(DateTime time)
        {
            long res = (time.ToUniversalTime().Ticks - 621355968000000000) / 10000000;
            return res;
        }

        #endregion

        #region SEA_ApiTestT-4 每月日期范围获取

        public static int GetDays(int year, int month)
        {
            var result = 0;
            var _30days = new List<int>() { 4, 6, 9, 11 };
            if (_30days.Contains(month))
            {
                result = 30;
            }
            else if (month == 2)
            {
                if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
                {
                    result = 29;
                }
                else { result = 28; }
            }
            else
            {
                result = 31;
            }
            return result;
        }





        #endregion
        #region json序列化后时间转换
        /// <summary>
        /// json序列化后时间转换
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static DateTime jsonFieldToDateTime(string str)
        {
            if (str.IndexOf(" ") != -1)
                str = str.Substring(0, str.IndexOf(" "));
            return Convert.ToDateTime(str.Replace("T", " "));
        }
        #endregion
       
        #region 写入文本日志
        static object logLockObj = new object();
        public static void txtWriter(string file_name, string str)
        {
            try
            {
                //写锁
                //logLockObj.EnterWriteLock();
                lock (logLockObj)
                {
                    string dir = AppDomain.CurrentDomain.BaseDirectory + "/_Log/";                   
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



        #region AES加密解密

        /// <summary>
        /// AES加密
        /// </summary>
        /// <param name="inputdata">输入的数据</param>
        /// <param name="iv">向量128位(Iv的字符串长度为16)</param>
        /// <param name="key">加密密钥(key的长度为32)</param>
        /// <returns></returns>
        public static string AESEncrypt(string encryptString, string key, string iv)
        {
            //分组加密算法   
            Aes aesAlg = Aes.Create();
            byte[] inputByteArray = Encoding.UTF8.GetBytes(encryptString);//得到需要加密的字节数组       
            //设置密钥及密钥向量
            aesAlg.Key = Encoding.UTF8.GetBytes(key);
            aesAlg.IV = Encoding.UTF8.GetBytes(iv); 
            using (MemoryStream ms = new MemoryStream())
            {
                using (CryptoStream cs = new CryptoStream(ms, aesAlg.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    cs.Write(inputByteArray, 0, inputByteArray.Length);
                    cs.FlushFinalBlock();
                    byte[] cipherBytes = ms.ToArray();//得到加密后的字节数组   
                    cs.Close();
                    ms.Close();
                    //return cipherBytes;
                    return Convert.ToBase64String(cipherBytes); //返回字符串
                }
            }
        }

        /// <summary> 
        /// 解密数据 
        /// </summary> 
        /// <param name="Text"></param> 
        /// <param name="sKey">密钥，必须为8位</param> 
        /// <returns></returns> 
        public static string Decrypt(string Text, string sKey)
        {
            //sKey = sKey.Substring(0, 8);
            //byte[] inputByteArray = Convert.FromBase64String(Text);
            //DESCryptoServiceProvider des = new DESCryptoServiceProvider();
            //des.Key = ASCIIEncoding.ASCII.GetBytes(sKey);
            //des.IV = ASCIIEncoding.ASCII.GetBytes(sKey);
            //System.IO.MemoryStream ms = new System.IO.MemoryStream();
            //CryptoStream cs = new CryptoStream(ms, des.CreateDecryptor(), CryptoStreamMode.Write);
            //cs.Write(inputByteArray, 0, inputByteArray.Length);
            //cs.FlushFinalBlock();
            //cs.Close();
            //string res = Encoding.UTF8.GetString(ms.ToArray());
            //ms.Close();
            //return res;
            return AESDecrypt(Text, sKey, sKey).Replace("\0", "");
        }

        /// <summary>
        /// AES解密
        /// </summary>
        /// <param name="inputdata">输入的数据</param>
        /// <param name="iv">向量128位(Iv的字符串长度为16)</param>
        /// <param name="key">加密密钥(key的长度为32)</param>
        /// <returns></returns>
        public static string AESDecrypt(string decryptString, string key, string iv)
        {
            Aes aesAlg = Aes.Create();
            aesAlg.Key = Encoding.UTF8.GetBytes(key);
            aesAlg.IV = Encoding.UTF8.GetBytes(key);
            // Create a decrytor to perform the stream transform.
            //ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

            //SymmetricAlgorithm aesAlg = Rijndael.Create();
            //aesAlg.Key = Encoding.UTF8.GetBytes(key);
            //aesAlg.IV = Encoding.UTF8.GetBytes(iv);
            //Log.print($"Descrypt string length->{decryptString.Length}");
            byte[] inputByteArray = Convert.FromBase64String(FixBase64String(decryptString));//得到需要加密的字节数组
            //byte[] inputByteArray = Base64Decoder.Decoder.GetDecoded(decryptString);//得到需要加密的字节数组

            //byte[] decryptBytes = new byte[inputByteArray.Length];
            using (MemoryStream ms = new MemoryStream(inputByteArray))
            {
                using (CryptoStream cs = new CryptoStream(ms, aesAlg.CreateDecryptor(), CryptoStreamMode.Read))
                {
                    using (var srDecrypt = new StreamReader(cs, Encoding.UTF8))
                    {
                        return srDecrypt.ReadToEnd();
                    }
                }
            }
            //return decryptBytes;
            //return Encoding.UTF8.GetString(decryptBytes); //返回字符串
        }

        /// <summary>
        /// 網頁傳遞過的token會有編碼問題
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private static string FixBase64String(string input)
        {
            string output = input.Trim().Replace("&#x2B;", "+");
            //Log.print($"Descrypt string Fix ori->{output}  length->{output.Length}");
            if (output.Length % 4 > 0)
            {
                output = output.PadRight((output.Length + 4) - (output.Length % 4), '=');
            }
            //Log.print($"Fixed Base64->{output} length->{output.Length}");
            return output;
        }

        //public static string AESDecrypt(string decryptString, string key, string iv)
        //{
        //    SymmetricAlgorithm Aes = Rijndael.Create();
        //    algo.Key = Encoding.UTF8.GetBytes(key);
        //    algo.IV = Encoding.UTF8.GetBytes(iv);
        //    byte[] inputByteArray = Convert.FromBase64String(decryptString);//得到需要加密的字节数组
        //    byte[] decryptBytes = new byte[inputByteArray.Length];
        //    using (MemoryStream ms = new MemoryStream(inputByteArray))
        //    {
        //        using (CryptoStream cs = new CryptoStream(ms, algo.CreateDecryptor(), CryptoStreamMode.Read))
        //        {
        //            cs.Read(decryptBytes, 0, decryptBytes.Length);
        //            cs.Close();
        //            ms.Close();
        //        }
        //    }
        //    //return decryptBytes;
        //    return Encoding.UTF8.GetString(decryptBytes); //返回字符串
        //}
        //public static byte[] Decrypt(byte[] cipher, string password)
        //{
        //    MemoryStream memoryStream;
        //    CryptoStream cryptoStream;
        //    Rijndael rijndael = Rijndael.Create();
        //    Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(password, SALT);
        //    rijndael.Key = pdb.GetBytes(32);
        //    rijndael.IV = pdb.GetBytes(16);
        //    memoryStream = new MemoryStream();
        //    cryptoStream = new CryptoStream(memoryStream, rijndael.CreateDecryptor(), CryptoStreamMode.Write);
        //    cryptoStream.Write(cipher, 0, cipher.Length);
        //    cryptoStream.Close();
        //    return memoryStream.ToArray();
        //}

        #endregion


        #region 公共方法 加密
        public static string GetStrRandom()
        {
            Random rd = new Random();
            string str = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            string result = "";
            for (int i = 0; i < 6; i++)
            {
                result += str[rd.Next(str.Length)];
            }
            return result;
        }

        public static string MD5Encrypt(string password, Encoding encode)
        {
            var md5Hasher = MD5.Create();//new MD5CryptoServiceProvider();
            byte[] hashedDataBytes;
            hashedDataBytes = md5Hasher.ComputeHash(encode.GetBytes(password));
            StringBuilder tmp = new StringBuilder();
            foreach (byte i in hashedDataBytes)
            {
                tmp.Append(i.ToString("x2"));
            }
            return tmp.ToString();
        }

        public static bool verToken(string k, string token)
        {
            if (MD5Encrypt(k, Encoding.UTF8) == token)
                return true;
            else
                return false;
        }
        #endregion

        public static int GetHdByNumber(decimal number)
        {
            if (number.ToString().IndexOf('.') == -1) { return 0; }
            return number == 0 ? 0 : number.ToString().Split('.')[1].TrimEnd('0').Count();
        }

        public static Dictionary<T, int> GetEnumDic<T>() where T : System.Enum
        {
            return typeof(T).GetEnumValues().Cast<T>().ToDictionary(k => k, v => Convert.ToInt32(v));
        }

        //ip转int
        public static long IpToInt(string ip)
        {
            char[] separator = new char[] { '.' };
            string[] items = ip.Split(separator);
            if (items.Length < 4)
            {
                return 0;
            }
            return long.Parse(items[0]) << 24
                    | long.Parse(items[1]) << 16
                    | long.Parse(items[2]) << 8
                    | long.Parse(items[3]);
        }


        #region 发送邮件

        /// <summary>
        /// 发送邮件(多人)
        /// </summary>
        /// <param name="emailList">收件人列表</param>
        /// <param name="emailfrom">抄送人</param>
        /// <param name="emailusername">邮箱账号</param>
        /// <param name="emailPwd">邮箱密码</param>
        /// <param name="body">内容</param>
        /// <returns></returns>
        public static string sendMail(List<string> emailList, string emailfrom, string emailusername, string emailPwd, string body, string title = "SEA通知", string nickname = "SEA")
        {
            MailMessage msg = new MailMessage();
            try
            {
                foreach (var email in emailList)
                {
                    msg.To.Add(email);//收件人地址 
                }
                msg.CC.Add(emailfrom);//抄送人地址 

                msg.From = new MailAddress(emailusername, nickname);//发件人邮箱，名称 

                msg.Subject = title;//邮件标题 
                msg.SubjectEncoding = System.Text.Encoding.UTF8;//标题格式为UTF8 

                msg.Body = body;//邮件内容 
                msg.BodyEncoding = System.Text.Encoding.UTF8;//内容格式为UTF8 
                msg.IsBodyHtml = true;
                SmtpClient client = new SmtpClient();


                client.Host = "smtp.SEA_ApiTestail.com";//SMTP服务器地址 
                client.Port = 587;//SMTP端口，QQ邮箱填写587 
                //client.Host = "smtp.qq.com";//SMTP服务器地址 
                //client.Port = 25;//SMTP端口，QQ邮箱填写587 
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;

                client.EnableSsl = true;//启用SSL加密 
                client.Credentials = new System.Net.NetworkCredential(emailusername, emailPwd);


                client.Send(msg);//发送邮件
            }
            catch (Exception e)
            {
                return e.Message;
            }
            return "1";
        }
        #endregion

        /// <summary>
        /// URL字符编码
        /// </summary>
        public static string UrlEncode(string str) => WebUtility.UrlEncode(str);
        public static string UrlDecode(string str) => WebUtility.UrlDecode(str);

    }

}