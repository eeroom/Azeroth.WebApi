﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Net.Http;
using Owin;
[assembly: Microsoft.Owin.OwinStartup(typeof(Azeroth.WebApiOwinIIS.Startup))]
namespace Azeroth.WebApiOwinIIS
{
    public class Startup
    {
        public void Configuration(Owin.IAppBuilder app)
        {
            HttpConfiguration config = new HttpConfiguration();
            config.Routes.MapHttpRoute("htt", "{controller}/{action}");
            app.UseWebApi(config);
        }
    }
}