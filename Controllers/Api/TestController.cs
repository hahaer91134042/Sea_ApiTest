using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Org.BouncyCastle.Asn1.X509;
using SEA_ApiTest.DAO;
using SEA_ApiTest.DAO.DTO;
using SEA_ApiTest.Models;
using SEA_ApiTest.Models.Tp01DB;
using SEA_ApiTest.Utils;
using System.Numerics;
using System.Security.Policy;
using static SEA_ApiTest.Controllers.Api.TestController;

namespace SEA_ApiTest.Controllers.Api
{
    [Route("api")]
    [ApiController]
    public class TestController : BaseController<TestDaoCollection>
    {
        public TestController(GmDbList dbs, IHttpContextAccessor httpContextAccessor) : base(dbs, httpContextAccessor)
        {
        }

        public class TestDaoCollection: IDaoCollection
        {
            public Lazy<SyncAgentInfoDAO> agentInfo { get; set; }
            public Lazy<AccountDAO> account { get; set; }
        }
        public class Data
        {
            public class LoginLog
            {
                public int agentid { get; set; }
                public string param { get { return _param; } set { _param = value.Replace(' ', '+'); } }
                public long time { get; set; }
                public string token { get; set; } = "";

                private string _param = "";
            }

            public class GameSpin
            {
                public string account { get; set; } = "";
                public int game_id { get; set; }
                public string live_order_id { get; set; } = "";
                public int autospin { get; set; }
                public double bet { get; set; }
                public string param { get; set; } = "";
            }
        }

        private void printBaseRequestInfo(string flag,params object[] data)
        {
            Log.print($"ApiTest {flag} Request url->{Request.GetRawUrl()}");
            Log.print($"ApiTest {flag} Request form data->{Request.Form.toJsonString()}");
            Log.print($"ApiTest {flag} input->{data.toJsonString()}");
        }

        [Route("func")]
        public object Func()
        {
            var str = "O012345678901234567890123";
            return new
            {
                length=str.Length,
                sub8=str.Substring(str.Length-13,13),
            };
        }


        [HttpPost]
        [Route("LoginLog")]
        public object LoginLog([FromForm]Data.LoginLog data)
        {
            try
            {
                printBaseRequestInfo("LoginLog", data);

                var agent = dao.agentInfo.Value.ConfigAgent;
                //var account= dao.account.Value.GetReadList();//devtony01
                //var account = "devHill01";
                string trustCode = agent.GetDecryptTrustCode();
                //int agent_id = agent.AgentId;
                var sysCode = agent.GetDecryptSysCode();
                //请求第三方
                //int type = 2;     //type 1登入 2登出
                //string param = Util.AESEncrypt(string.Format("{0},{1},{2}", type, account, ""), sysCode,sysCode);
                //long unixTime = Util.GetUnix(DateTime.Now);
                //string threeToken = Util.MD5hash(agent_id.ToString() + unixTime + trustCode);
                //var query =string.Format("agentid={0}&param={1}&time={2}&token={3}", agent_id, param, unixTime, threeToken);



                var checkToken = Util.verToken($"{data.agentid}{data.time}{trustCode}", data.token);
                //var rawUrl = HttpContext.Request.GetRawUrl();
                //var decode = Util.Decrypt(rawUrl.QueryVal()["param"], sysCode);
                var decode = Util.Decrypt(data.param, sysCode);

                var check = new
                {
                    checkToken,
                    decode
                };

                
                Log.print($"ApiTest LoginLog check->{check.toJsonString()}");

                return new
                {
                    ver=App.Version,
                    msg = "Success",
                    state = 0,
                    check
                };
            }
            catch (Exception ex) 
            {
                Log.printError(ex, "LoginLog");
                return new
                {
                    ver=App.Version,
                    msg = $"error->{ex}",
                    state = 1
                };
            }
        }

        [HttpPost]
        [Route("OidDash")]
        public object OidDash([FromForm]string oid)
        {

            return new
            {
                oid = oid,
                rey = addDash(oid, 16, 5),
                msg="success"
            };
        }

        private string addDash(string numstr,int start,int end)
        {
            var s = numstr.Substring(0, start);
            var m=numstr.Substring(start,numstr.Length-(start+end));
            var e = numstr.Substring(numstr.Length - end, end);

            return $"{s}-{m}-{e}";
        }

        [HttpPost]
        [Route("GameSpin")]
        public object GameSpin([FromForm]Data.GameSpin data)
        {
            try
            {
                printBaseRequestInfo("GameSpin", data);

                var agent = dao.agentInfo.Value.ConfigAgent;
                //var account= dao.account.Value.GetReadList();//devtony01
                //var account = "devHill01";
                string trustCode = agent.GetDecryptTrustCode();
                //int agent_id = agent.AgentId;
                var sysCode = agent.GetDecryptSysCode();

                var check = new
                {
                    input= $"{data.account},{data.game_id},{data.live_order_id},{data.autospin},{data.bet}",
                    decode=Util.Decrypt(data.param, sysCode),
                };

                Log.print($"ApiTest GameSpin check->{check.toJsonString()}");

                return new
                {
                    ver = App.Version,
                    msg = "Success",
                    state = 0,
                    check
                };
            }
            catch (Exception ex)
            {
                Log.printError(ex, "GameSpin");
                return new
                {
                    ver = App.Version,
                    msg = $"error->{ex}",
                    state = 1
                };
            }
        }

    }
}
