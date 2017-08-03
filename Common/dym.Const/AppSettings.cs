using System;
using System.Collections.Generic;
namespace dym.Const
{
    public static class AppSettings
    {
        /// <summary>
        /// 数据库连接字符串
        /// </summary>
        public static String ConnStr { get; set; }
        /// <summary>
        /// Ioc管理DLL列表
        /// </summary>
        public static List<string> IocDll { get; set; }
    }
}
