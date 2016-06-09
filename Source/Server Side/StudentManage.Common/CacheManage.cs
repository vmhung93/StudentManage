using System;
using System.Configuration;
using System.Web;

namespace StudentManage.Common
{
    public static class CacheManage
    {
        public static object Get(string key)
        {
            return HttpContext.Current.Cache.Get(key);
        }

        public static void Set(string key, object value)
        {
            HttpContext.Current.Cache.Insert(key, value);
        }
    }
}