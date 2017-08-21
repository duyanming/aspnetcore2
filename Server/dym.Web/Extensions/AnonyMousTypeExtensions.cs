using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace dym.Web.Extensions
{
    /// <summary>
    /// 扩展类
    /// </summary>
    public static class AnonyMousTypeExtensions
    {
        /// <summary>
        /// 对象转换
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="anonymousObject"></param>
        /// <returns></returns>
        public static T ToT<T>(this object anonymousObject) where T:class,new()
        {
            if (anonymousObject == null)
            {
                return default(T);
            }
            return Newtonsoft.Json.JsonConvert.DeserializeObject<T>(Newtonsoft.Json.JsonConvert.SerializeObject(anonymousObject));
        }
        /// <summary>
        /// 对象转换List
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="anonymousObject"></param>
        /// <returns></returns>
        public static List<T> ToTs<T>(this object anonymousObject) where T : class, new()
        {
            if (anonymousObject == null)
            {
                return default(List<T>);
            }
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<T>>(Newtonsoft.Json.JsonConvert.SerializeObject(anonymousObject));
        }
    }
}
