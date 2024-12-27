using Newtonsoft.Json;
using System.Dynamic;

namespace SEA_ApiTest.Models.Impl
{
    public abstract class IDynamicData : DynamicObject
    {
        private IDictionary<string, object?> _objectMembers = new Dictionary<string, object?>();

        public override bool TryGetMember(GetMemberBinder binder, out object? result)
        {
            if (!this._objectMembers.ContainsKey(binder.Name))
            {
                result = null;
                return false;
            }
            else
            {
                result = this._objectMembers[binder.Name];
                return true;
            }
        }

        public override bool TrySetMember(SetMemberBinder binder, object? value)
        {
            if (!this._objectMembers.ContainsKey(binder.Name))
            {
                this._objectMembers.Add(binder.Name, value);
                return true;
            }
            else
            {
                this._objectMembers[binder.Name] = value;
                return true;
            }
        }

        public override string ToString() => toJsonString();

        public string Output(Action<dynamic>? back = null)
        {
            back?.Invoke(this);
            return toJsonString();
        }

        public object OutputObj(Action<dynamic>? back = null)
        {
            back?.Invoke(this);
            return combinData();
        }

        public string toJsonString()=> JsonConvert.SerializeObject(combinData());

        private Dictionary<string,object?> combinData()
        {
            var result = new Dictionary<string, object?>();

            foreach (var prop in GetType().GetProperties())
            {
                if(!prop.isDefinedAttr<JsonIgnoreAttribute>())
                    result.Add(prop.Name, prop.GetValue(this));
            }

            foreach (var item in _objectMembers)
            {
                result.Add(item.Key, item.Value);
            }

            return result;
        }
    }
}
