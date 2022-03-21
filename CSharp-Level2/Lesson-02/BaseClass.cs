using System.Collections.Generic;

namespace Lesson_02
{
    public class BaseClass : IBaseClass
    {
        readonly Dictionary<string, object> dic = new();
        public Dictionary<string, object> GetArray()
        {
            dic.Add("First", "Levon");
            dic.Add("LastName", "Shakhnazaryan");
            dic.Add("Age", 36);
            dic.Add("Salary", 1500000);
            return dic;
        }
        public void AddArray(string key, object value)
        {
            if (!dic.ContainsKey(key))
                dic.Add(key, value);
            else
                dic[key] = value;
        }
        public void EditArray(string key, object value)
        {
            if (dic.ContainsKey(key))
                dic[key] = value;
        }
        public void DeleteArray(string key)
        {
            if (dic.ContainsKey(key))
                dic.Remove(key);
        }
    }

    public interface IBaseClass
    {
        Dictionary<string, object> GetArray();
        void AddArray(string key, object value);
        void EditArray(string key, object value);
        void DeleteArray(string key);
    }
}