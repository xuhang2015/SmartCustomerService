﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace SmartCustomerService.ResponseWebAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();
            

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "ResponseWebApi/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            //config.Filters.Add(new NoHandleExceptionFilter());
        }
    }
}
