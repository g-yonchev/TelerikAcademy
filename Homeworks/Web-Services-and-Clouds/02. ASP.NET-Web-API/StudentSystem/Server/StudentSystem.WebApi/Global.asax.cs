﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace StudentSystem.WebApi
{
	public class WebApiApplication : HttpApplication
	{
		protected void Application_Start()
		{
			DatabaseConfig.Initialize();
			AutoMapperConfig.RegisterMappings(Assembly.Load("StudentSystem.WebApi"));
            GlobalConfiguration.Configure(WebApiConfig.Register);
		}
	}
}
