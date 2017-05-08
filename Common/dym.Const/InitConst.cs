using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;

namespace dym.Const
{
    public  class InitConst
    {
        private IConfiguration settings { get; }
        public InitConst(IConfiguration settings) {
            this.settings = settings.GetSection("AppSettings");
            InitConfig();
        }
        public  bool InitConfig() {
            AppSettings.ConnStr = settings["ConnStr"];
            return true;
        }
    }
}
