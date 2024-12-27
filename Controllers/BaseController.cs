
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Linq.Expressions;
using System.Text;
using System.Web;
using SEA_ApiTest.Models;
using Microsoft.Extensions.Logging;
using SEA_ApiTest.DAO;

namespace SEA_ApiTest.Controllers
{
    public class BaseController<T> : ControllerBase  where T: IDaoCollection, new()
    {
        //protected ISession? session;
        //protected DAWriteDbContext _dbw;
        //protected DAReadDbContext _dbr;
        //protected readonly Logger Logger;
        protected GmDbList _dbs;
        protected T dao;
        protected IHttpContextAccessor _contextAccessor;
        //protected int langID = 0;
        public BaseController(GmDbList dbs, IHttpContextAccessor httpContextAccessor)
        {
            _contextAccessor= httpContextAccessor;
            WebContext.Refresh(httpContextAccessor);
            //session = httpContextAccessor?.HttpContext?.Session;
            dao = new T();
            dao.init(dbs);
            _dbs = dbs;
            //_dbw = dbw;
            //_dbr = dbr;
        }


        //protected T GetDAO<T>()
        //{
        //    var t = typeof(T);
        //    if (!(t?.BaseType?.Name ?? "").Equals(typeof(BaseDAO<,>).Name))
        //        throw new InvalidCastException($"Instance Type must implement {typeof(BaseDAO<,>).Name}");

        //    var con = (from c in t.GetConstructors()
        //               where c.GetParameters().Length > 0
        //               select c).FirstOrDefault();
        //    if (con == null)
        //        throw new InvalidCastException($"{t.Name} Constructor Parameter Not Match");

        //    var dbw = _dbs.write.FirstOrDefault(d => con.GetParameters().Any(p => p.ParameterType.Name == d.GetType().Name));
        //    var dbr = _dbs.read.FirstOrDefault(d => con.GetParameters().Any(p => p.ParameterType.Name == d.GetType().Name));

        //    return (T)Activator.CreateInstance(t, dbw, dbr)!;
        //}

        //protected ErrorResponse ResponseError(ErrorCodeEnum code = ErrorCodeEnum.UnknownError)
        //    => new ErrorResponse(code);

        //protected decimal GetLangHd(AuthorizeConfigDAO authDAO,GameCurrencyDAO curDAO)
        //{
        //    int cur_id = authDAO.GetReadModel(1)!.Value1!.toInt();// Convert.ToInt32(new BLL.dbHelper<Model.authorize_config>().GetModel(1).value1);
        //    var cur_decimal = curDAO.GetReadModel((sbyte)cur_id)!.CurDecimal!.Value;//new BLL.dbHelper<Model.game_currency>().GetModel(cur_id).cur_decimal;
        //    return (decimal)Math.Pow(10, cur_decimal);
        //}

        //protected List<SyncAgentInfo> GetAgentListByRole(SyncAgentInfoDAO dao, Expression<Func<SyncAgentInfo, bool>> back, List<int>? roles = null)
        //{
        //    var roleType = ManagerHelper.GetAdminInfo()!.RoleType;
        //    if (roleType == 0)
        //        return dao.GetAgentList(back);
        //    if (roles == null)
        //        roles = ManagerHelper.GetRoleOfAgent();
        //    return dao.GetAgentList(back, roles);
        //}

        //protected bool ChkAdminLv(NavEnum nav,ActionEnum action, TbManagerRoleValueDAO? roleDAO=null,bool isResp=false)
        //{
        //    var man= ManagerHelper.GetAdminInfo();
        //    if (roleDAO == null)
        //        roleDAO =dao.GetDAO<TbManagerRoleValueDAO>();
        //    if (roleDAO.hasPermission(man.RoleType,nav.getDescription(), action.getDescription()))
        //    {
        //        SessionHelper.SetSession(SessionHelper.Flag.loginTimeout, DateTime.Now);
        //        SessionHelper.SetSession(SessionHelper.Flag.back_url,HttpContext.Request.GetEncodedPathAndQuery());
        //        return true;
        //    }
        //    else
        //    {
        //        if (isResp)
        //        {                    
        //            WebContext.Current?.Response
        //                .WriteAsync("<script type=\"text/javascript\">alert('" + GetLang("not_role") + "');history.go(-1);</script>");
        //        }
        //        return false;
        //    }
        //}






    }

    /// <summary>
    /// 提供延遲初始化
    /// 屬性只能使用Lazy<>
    /// </summary>
    public abstract class IDaoCollection
    {
        private GmDbList _dbs;

        public void init(GmDbList dbs)
        {
            _dbs = dbs;

            var lazyT = typeof(Lazy<>);
            foreach (var p in GetType().GetProperties())
            {
                if (p.PropertyType.Name != lazyT.Name)
                    continue;

                //var genericType = typeof(GenericClass<>);
                //Type[] t = { typeof(int) };
                //var toCreate = genericType.MakeGenericType(t);
                //object o = Activator.CreateInstance(toCreate, "brian", "scaturro");

                var argT = p.PropertyType.GenericTypeArguments.First();
                var func = Expression.Lambda(Expression.Constant(GetDAO(argT))).Compile().DynamicInvoke();

                p.SetValue(
                    this,
                    Activator.CreateInstance(p.PropertyType,func)
                    );
            }
        }


        public T GetDAO<T>() => (T)GetDAO(typeof(T));

        private object GetDAO(Type t)
        {
            if (!(t?.BaseType?.Name ?? "").Equals(typeof(BaseDAO<,>).Name))
                throw new InvalidCastException($"Instance Type must implement {typeof(BaseDAO<,>).Name}");

            var con = (from c in t.GetConstructors()
                       where c.GetParameters().Length > 0
                       select c).FirstOrDefault();
            if (con == null)
                throw new InvalidCastException($"{t.Name} Constructor Parameter Not Match");

            //var param = (from p in con.GetParameters()
            //             select new
            //             {
            //                 ParamName=p.ParameterType.Name
            //             }).toJsonString();
            //Log.d($"---GetDAO constructor  params leng->{con.GetParameters().Length}  params->{param.toJsonString()}");

            var dbw = _dbs.write.FirstOrDefault(d => con.GetParameters().Any(p => p.ParameterType.Name == d.GetType().Name));
            var dbr = _dbs.read.FirstOrDefault(d => con.GetParameters().Any(p => p.ParameterType.Name == d.GetType().Name));

            return Activator.CreateInstance(t, dbw, dbr)!;
        }
    }


    //public abstract class DaoCache : List<object>
    //{
    //    private GmDbList _dbs;
    //    public DaoCache(GmDbList dbs)
    //    {
    //        _dbs = dbs;

    //    }
    //    public T Find<T>()
    //    {
    //        var dt = typeof(T);
    //        var tempDAO = this.FirstOrDefault(d => d.GetType().Name == dt.Name);
    //        if (tempDAO != null)
    //            return (T)tempDAO;

    //        var dao = GetDAO<T>()!;
    //        Add(dao);

    //        return dao;
    //    }

    //    private T GetDAO<T>()
    //    {
    //        var t = typeof(T);
    //        if (!(t?.BaseType?.Name ?? "").Equals(typeof(BaseDAO<,>).Name))
    //            throw new InvalidCastException($"Instance Type must implement {typeof(BaseDAO<,>).Name}");

    //        var con = (from c in t.GetConstructors()
    //                   where c.GetParameters().Length > 0
    //                   select c).FirstOrDefault();
    //        if (con == null)
    //            throw new InvalidCastException($"{t.Name} Constructor Parameter Not Match");

    //        //var param = (from p in con.GetParameters()
    //        //             select new
    //        //             {
    //        //                 ParamName=p.ParameterType.Name
    //        //             }).toJsonString();
    //        //Log.d($"---GetDAO constructor  params leng->{con.GetParameters().Length}  params->{param.toJsonString()}");

    //        var dbw = _dbs.write.FirstOrDefault(d => con.GetParameters().Any(p => p.ParameterType.Name == d.GetType().Name));
    //        var dbr = _dbs.read.FirstOrDefault(d => con.GetParameters().Any(p => p.ParameterType.Name == d.GetType().Name));

    //        return (T)Activator.CreateInstance(t, dbw, dbr)!;
    //    }
    //}
}