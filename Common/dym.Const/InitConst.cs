using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Extensions.Configuration;

namespace dym.Const
{
    public class InitConst
    {
        private IConfiguration settings { get; }
        public InitConst(IConfiguration settings)
        {
            this.settings = settings.GetSection("AppSettings");
            InitConfig();
        }
        public bool InitConfig()
        {
            AppSettings.ConnStr = settings["ConnStr"];
            AppSettings.IocDll = settings["IocDll"].ToString().Split(',').ToList();
            return true;
        }
    }
}
